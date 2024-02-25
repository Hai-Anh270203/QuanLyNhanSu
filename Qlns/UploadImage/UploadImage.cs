using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Qlns.UploadImage
{
    internal class UploadImage
    {
        public void UploadImageToDatabase(Image Anh)
        {
            byte[] HinhAnh = ImageToByteArray(Anh);
            ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
            if (HinhAnh != null)
            {
                using (SqlConnection conn = kn.OpenConnection())
                {
                    string sql = "INSERT INTO Anh (Picure) VALUES (@Anh)";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.Add("@Anh", SqlDbType.VarBinary, HinhAnh.Length).Value = HinhAnh;
                    command.ExecuteNonQuery();
                    MessageBox.Show("ok");
                }
            }

        }

        public byte[] ImageToByteArray(Image Anh)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Anh.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        //chuyển từ byte[] sang image
        Image ByteArraytoImage(byte[] b)
        {
            MemoryStream m=new MemoryStream(b);
            return Image.FromStream(m);
        }

    }
}

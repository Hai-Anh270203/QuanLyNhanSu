using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.BUS
{
    internal class ChucDanhBUS
    {
        ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();

        public void ThemCD(string TenChucDanh)
        {
            try
            {
                SqlConnection ketnoi = Kn.OpenConnection();
                string query = "INSERT INTO ChucDanh (TenChucDanh) VALUES (@TenChucDanh)";
                SqlCommand haianhheo = new SqlCommand(query, ketnoi);
                haianhheo.Parameters.AddWithValue("@TenChucDanh", TenChucDanh); // Sử dụng giá trị của tham số truyền vào

                int rowsAffected = haianhheo.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm chức danh thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm chức danh không thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

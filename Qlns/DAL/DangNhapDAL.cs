using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class DangNhapDAL
    {
        public string DangNhap(string TaiKhoan ,string MatKhau ,string Role)
        {
            ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();
            try
            {
                string TenTK = "";
                SqlConnection conn=Kn.OpenConnection();
                string query = "SELECT Users.TaiKhoan FROM Users " +
                        "INNER JOIN Role_User ON Users.Id = Role_User.IdUser " +
                        "INNER JOIN Role ON Role_User.IdRole = Role.Id " +
                        "WHERE Users.TaiKhoan = @TaiKhoan AND Users.MatKhau = @MatKhau " +
                        "AND Users.Status = 1 AND Role.Role = @Role;";
                SqlCommand command=new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@TaiKhoan", TaiKhoan);
                command.Parameters.AddWithValue("@MatKhau", MatKhau);
                command.Parameters.AddWithValue("@Role", Role);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TenTK = reader.GetString(reader.GetOrdinal("TaiKhoan"));
                }
                MessageBox.Show("Da lay du lieu");
                return TenTK;
    
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu có
                Console.WriteLine("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}

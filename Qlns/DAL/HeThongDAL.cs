using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Qlns.DAL
{
    internal class HeThongDAL
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();

        public List<DTO.HeThongDTO> DSTaiKhoan()
        {
            List<DTO.HeThongDTO> TaiKhoanList = new List<DTO.HeThongDTO>();

            try
            {
                using (SqlConnection connection = kn.OpenConnection())
                {
                    string query = "SELECT Role_User.Id, Role_User.IdUser, Users.HoTen, Role.Role, Users.TaiKhoan, Users.MatKhau " +
                                    "FROM Role_User " +
                                    "INNER JOIN Users ON Users.Id = Role_User.IdUser " +
                                    "INNER JOIN Role ON Role_User.IdRole = Role.Id;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DTO.HeThongDTO Tk = new DTO.HeThongDTO()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    IdUser = reader.GetInt32(reader.GetOrdinal("IdUser")),
                                    HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
                                    Role = reader.GetString(reader.GetOrdinal("Role")),
                                    TaiKhoan = reader.GetString(reader.GetOrdinal("TaiKhoan")),
                                    MatKhau = reader.GetString(reader.GetOrdinal("MatKhau")),

                                };
                                TaiKhoanList.Add(Tk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                MessageBox.Show("List tài khoản sai" + ex.Message);
                return null;
            }

            return TaiKhoanList;
        }
        public void AddRole(int IdUser, string IdRole)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = kn.OpenConnection())
                {
                    // Tạo câu lệnh SQL để chèn dữ liệu vào bảng Role_User
                    string query = "INSERT INTO Role_User (IdUser, IdRole) " +
                                   "VALUES ((IdUser = @IdUser), (SELECT Id FROM Role WHERE Role = @Role))";

                    // Tạo đối tượng SqlCommand để thực thi câu lệnh SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@IdUser", IdUser);
                        command.Parameters.AddWithValue("@IdRole", IdRole);

                        // Thực thi câu lệnh SQL và lấy số hàng bị ảnh hưởng
                        int rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra
                Console.WriteLine("Lỗi khi thêm tài khoản: " + ex.Message);
                MessageBox.Show("Đã xảy ra lỗi khi thêm tài khoản: " + ex.Message);
            }
        }
    }
}

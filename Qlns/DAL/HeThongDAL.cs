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
                    string query = "SELECT Role.Id FROM Users " +
                               "INNER JOIN Role_User ON Users.Id = Role_User.IdUser " +
                               "INNER JOIN Role ON Role_User.IdRole = Role.Id " +
                               "WHERE Users.TaiKhoan = @TaiKhoan AND Users.MatKhau = @MatKhau " +
                               "AND Users.Status = 1 AND Role.Role = @Role;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DTO.TienLuongDTO Tk = new DTO.TienLuongDTO()
                                {
                                    

                                };

                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                MessageBox.Show("List tien luong sai" + ex.Message);
                return null;
            }

            return TaiKhoanList;
        }
    }
}

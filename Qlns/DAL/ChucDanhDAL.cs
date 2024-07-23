using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class ChucDanhDAL
    {
        ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();
        public List<DTO.ChucDanhDTO> LayChucDanh()
        {
            List<DTO.ChucDanhDTO> ChucDanhList = new List<ChucDanhDTO>();


            SqlConnection ketnoi = Kn.OpenConnection();
            string query = "SELECT * FROM ChucDanh WHERE Status = 1;";
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                DTO.ChucDanhDTO CD = new DTO.ChucDanhDTO()
                {
                    Id = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Id")),
                    TenChucDanh=sqlDataReader.GetString(sqlDataReader.GetOrdinal("TenChucDanh")),
                };
                // Process or use the ChucDanhDTO object here
                ChucDanhList.Add(CD);
            }
       
            return ChucDanhList;

        }
        public bool ThemChucDanh(string TenChucDanh)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "INSERT INTO ChucDanh (TenChucDanh) VALUES (@TenChucDanh);";
                    using (SqlCommand command = new SqlCommand(query, ketnoi))
                    {
                        command.Parameters.AddWithValue("@TenChucDanh", TenChucDanh);

                  
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào được thêm không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm chức danh thành công.");
                            return true;
                        }
                        else
                        {
                            // Không có bản ghi nào được thêm, cập nhật thất bại
                            MessageBox.Show("Thêm chức danh không thành công.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool SuaChucDanh(int Id, string TenChucDanh)
        {
            try
            {
                SqlConnection ketnoi = Kn.OpenConnection();
                string query = "UPDATE ChucDanh SET TenChucDanh = @TenChucDanh WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, ketnoi);

                // Thêm các tham số cần thiết
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@TenChucDanh", TenChucDanh);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thông tin chức danh thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sửa thông tin chức danh không thành công!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

        public bool XoaChucDanh(int id, int status)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "UPDATE ChucDanh SET Status = @Status WHERE Id = @Id;";
                    using (SqlCommand command = new SqlCommand(query, ketnoi))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Status", 0);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào bị ảnh hưởng không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa chức danh thành công");
                            return true;
                        }
                        else
                        {
                            // Không có bản ghi nào bị ảnh hưởng, cập nhật thất bại
                            MessageBox.Show("Xóa chức danh không thành công");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

    }
}


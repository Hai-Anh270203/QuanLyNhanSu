using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class CongTacDAL
    {
        ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();

        public List<CongTacDTO> LayCongTac()
        {
            List<CongTacDTO> CongTacList = new List<CongTacDTO>();

            using (SqlConnection ketnoi = Kn.OpenConnection())
            {
                string query = "SELECT * FROM CongTac WHERE Status = 1;";
                using (SqlCommand cmd = new SqlCommand(query, ketnoi))
                {
                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            CongTacDTO CD = new CongTacDTO()
                            {
                                Id = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Id")),
                                TenCongTac = sqlDataReader.GetString(sqlDataReader.GetOrdinal("TenCongTac")),
                                Status = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                            };
                            CongTacList.Add(CD);
                        }
                    }
                }
            }

            return CongTacList;
        }

        public bool ThemCongTac(string TenCongTac)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "INSERT INTO CongTac (TenCongTac) VALUES (@TenCongTac);";
                    using (SqlCommand command = new SqlCommand(query, ketnoi))
                    {
                        command.Parameters.AddWithValue("@TenCongTac", TenCongTac);

                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào được thêm không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm công tác thành công.");
                            return true;
                        }
                        else
                        {
                            // Không có bản ghi nào được thêm, cập nhật thất bại
                            MessageBox.Show("Thêm công tác không thành công.");
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


        public bool SuaCongTac(int Id, string TenCongTac)
        {
            try
            {
                SqlConnection ketnoi = Kn.OpenConnection();
                string query = "UPDATE CongTac SET TenCongTac = @TenCongTac WHERE Id = @Id;";
                SqlCommand command = new SqlCommand(query, ketnoi);

                // Thêm các tham số cần thiết
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@TenCongTac", TenCongTac);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa công tác thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Sửa công tác không thành công!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public void XoaCongTac(int Id, int Status)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "UPDATE CongTac SET Status = @Status  WHERE Id = @Id;";
                    using (SqlCommand command = new SqlCommand(query, ketnoi))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Status", 0);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa công tác thành công.");
                        }
                        else
                        {
                            MessageBox.Show("Xóa công tác không thành công.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}

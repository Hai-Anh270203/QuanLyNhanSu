using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Qlns.DAL
{
    internal class TienLuongDAL
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();

        public List<DTO.TienLuongDTO> LayTienLuong()
        {
            List<DTO.TienLuongDTO> TienLuongList = new List<DTO.TienLuongDTO>();

            try
            {
                using (SqlConnection connection = kn.OpenConnection())
                {
                    string query =
                        "SELECT * FROM TienLuong " +

                        "WHERE TienLuong.Status = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DTO.TienLuongDTO TienLuong = new DTO.TienLuongDTO()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    BacLuong = reader.GetInt32(reader.GetOrdinal("BacLuong")),
                                    HeSo = reader.GetInt32(reader.GetOrdinal("HeSo")),
                                    PhuCap = reader.GetInt32(reader.GetOrdinal("PhuCap")),
                                    GhiChu = reader.GetString(reader.GetOrdinal("GhiChu")),

                                };

                                TienLuongList.Add(TienLuong);
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

            return TienLuongList;
        }

        //add Lương
        public int AddTL(string BacLuong, string HeSo, string PhuCap, string GhiChu)
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "INSERT INTO TienLuong( BacLuong, HeSo, PhuCap, GhiChu) " +
                                   "VALUES ( @BacLuong, @HeSo, @PhuCap, @GhiChu);";

                    using (cmd = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số và gán giá trị thực
                        cmd.Parameters.AddWithValue("@BacLuong", BacLuong);
                        cmd.Parameters.AddWithValue("@HeSo", HeSo);
                        cmd.Parameters.AddWithValue("@PhuCap", PhuCap);
                        cmd.Parameters.AddWithValue("@GhiChu", GhiChu);

                        // Thực thi câu lệnh SQL và trả về số hàng đã thay đổi trong cơ sở dữ liệu
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Trả về số hàng được tác động (thường là số hàng đã thêm)
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bậc lương: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi xảy ra
            }
        }
        public int SuaTL(int Id, string BacLuong, string HeSo, string PhuCap, string GhiChu)
        {
            try
            {
                string query = "UPDATE TienLuong SET BacLuong = @BacLuong, HeSo = @HeSo, PhuCap=@PhuCap, GhiChu=@GhiChu WHERE Id = @Id;";
                using (SqlConnection connection = kn.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Thêm các tham số và gán giá trị thực
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@BacLuong", BacLuong);
                    cmd.Parameters.AddWithValue("@HeSo", HeSo);
                    cmd.Parameters.AddWithValue("@PhuCap", PhuCap);
                    cmd.Parameters.AddWithValue("@GhiChu", GhiChu);

                    // Trả về số hàng được cập nhật
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa bậc lương: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi xảy ra
            }
        }

        public int XoaTL(int Id)
        {
            try
            {
                string query = "DELETE FROM TienLuong WHERE Id=@Id";
                using (SqlConnection connection = kn.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);
                    return cmd.ExecuteNonQuery(); // Trả về số hàng đã xóa
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa nhân viên: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi xảy ra
            }
        }
    }
}

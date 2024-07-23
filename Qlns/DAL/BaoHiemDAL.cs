using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class BaoHiemDAL
    {
        ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();
        public List<BaoHiemDTO> LayBaoHiem()
        {
            List<BaoHiemDTO> BaoHiemList = new List<BaoHiemDTO>();

            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "SELECT * FROM BaoHiem WHERE Status = 1;";
                    using (SqlCommand cmd = new SqlCommand(query, ketnoi))
                    {
                        using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                BaoHiemDTO BH = new BaoHiemDTO()
                                {
                                    Id = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("Id")) ? 0 : sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Id")),
                                    NgayCap = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("NgayCap")) ? DateTime.MinValue : sqlDataReader.GetDateTime(sqlDataReader.GetOrdinal("NgayCap")),
                                    NoiCap = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("NoiCap")) ? string.Empty : sqlDataReader.GetString(sqlDataReader.GetOrdinal("NoiCap")),
                                    GhiChu = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("GhiChu")) ? string.Empty : sqlDataReader.GetString(sqlDataReader.GetOrdinal("GhiChu")),
                                    IdNhanVien = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("IdNhanVien")) ? 0 : sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("IdNhanVien")),
                                    TienBaoHiem = sqlDataReader.IsDBNull(sqlDataReader.GetOrdinal("TienBaoHiem")) ? 0 : sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("TienBaoHiem")),
                                   
                                };
                                BaoHiemList.Add(BH);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception ở đây
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return BaoHiemList;
        }

        public bool ThemBaoHiem(string NgayCap, string GhiChu, int TienBaoHiem, int IdNhanVien, string NoiCap)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "INSERT INTO BaoHiem (NgayCap, NoiCap, GhiChu, TienBaoHiem, IdNhanVien) " +
                                   "VALUES (@NgayCap, @NoiCap, @GhiChu, @TienBaoHiem, @IdNhanVien);";
                    using (SqlCommand cmd = new SqlCommand(query, ketnoi))
                    {
                        cmd.Parameters.AddWithValue("@NgayCap", NgayCap);
                        cmd.Parameters.AddWithValue("@NoiCap", NoiCap);
                        cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                        cmd.Parameters.AddWithValue("@TienBaoHiem", TienBaoHiem);
                        cmd.Parameters.AddWithValue("@IdNhanVien", IdNhanVien);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm bảo hiểm thành công.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Thêm bảo hiểm không thành công.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm bảo hiểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool SuaBaoHiem(int Id, string NgayCap, string GhiChu, int TienBaoHiem, int IdNhanVien, string NoiCap)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "UPDATE BaoHiem SET NgayCap=@NgayCap, NoiCap=@NoiCap, GhiChu=@GhiChu, TienBaoHiem=@TienBaoHiem, IdNhanVien=@IdNhanVien WHERE Id=@Id;";
                                   
                    using (SqlCommand cmd = new SqlCommand(query, ketnoi))
                    {
                        cmd.Parameters.AddWithValue("@Id",Id);
                        cmd.Parameters.AddWithValue("@NgayCap", NgayCap);
                        cmd.Parameters.AddWithValue("@NoiCap", NoiCap);
                        cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
                        cmd.Parameters.AddWithValue("@TienBaoHiem", TienBaoHiem);
                        cmd.Parameters.AddWithValue("@IdNhanVien", IdNhanVien);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sửa bảo hiểm thành công.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Sửa bảo hiểm không thành công.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa bảo hiểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public bool XoaBaoHiem(int Id, int Status)
        {
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    string query = "UPDATE BaoHiem SET Status = @Status WHERE Id = @Id;";

                    using (SqlCommand cmd = new SqlCommand(query, ketnoi))
                    {
                        cmd.Parameters.AddWithValue("@Id", Id);
                        cmd.Parameters.AddWithValue("@Status", 0);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xóa bảo hiểm thành công.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Xóa bảo hiểm không thành công.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa bảo hiểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

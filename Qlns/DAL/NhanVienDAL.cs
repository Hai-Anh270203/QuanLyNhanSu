using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class NhanVienDAL
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();

        public List <DTO.NhanVienDTO> GetNhanVienList()
        {
            List<DTO.NhanVienDTO> NhanVienList = new List<DTO.NhanVienDTO>();

            try
            {
                using (SqlConnection connection = kn.OpenConnection())
                {
                    string query =
                        "SELECT Users.Id AS IdUser, CongTac.Id AS IdCongTac, ChucDanh.Id AS IdChucDanh, Users.HoTen, Users.NgaySinh, " +
                        "Users.Email, Users.GioiTinh, Users.DiaChi, Users.DangVien, Users.HocVan, Users.CMND, Users.DuongDan, " +
                        "ChucDanh.TenChucDanh, CongTac.TenCongTac, HopDong.LoaiHopDong, HopDong.NgayBatDau, HopDong.NgayKetThuc, " +
                        "TienLuong.Id AS IdTienLuong, NhanVien.MaNhanVien " +
                        "FROM Users " +
                        "JOIN NhanVien ON NhanVien.IdUser = Users.Id " +
                        "JOIN ChucDanh ON ChucDanh.Id = NhanVien.IdChucDanh " +
                        "JOIN TienLuong ON NhanVien.IdTienLuong = TienLuong.Id " +
                        "JOIN HopDong ON HopDong.Id = NhanVien.IdHopDong " +
                        "JOIN CongTac ON CongTac.Id = NhanVien.IdCongTac " +
                        "WHERE NhanVien.Status = 1;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DTO.NhanVienDTO nhanVien = new DTO.NhanVienDTO()
                                {
                                    IdUser = reader.GetInt32(reader.GetOrdinal("IdUser")),
                                    HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
                                    NgaySinh = reader.GetDateTime(reader.GetOrdinal("NgaySinh")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    GioiTinh = reader.GetString(reader.GetOrdinal("GioiTinh")),
                                    CMND = reader.GetString(reader.GetOrdinal("CMND")),
                                    DiaChi = reader.GetString(reader.GetOrdinal("DiaChi")),
                                    DangVien = reader.GetString(reader.GetOrdinal("DangVien")),
                                    HocVan = reader.GetString(reader.GetOrdinal("HocVan")),
                                    TenCongTac = reader.GetString(reader.GetOrdinal("TenCongTac")),
                                    TenChucDanh = reader.GetString(reader.GetOrdinal("TenChucDanh")),
                                    LoaiHopDong = reader.GetString(reader.GetOrdinal("LoaiHopDong")),
                                    NgayBatDau = reader.GetDateTime(reader.GetOrdinal("NgayBatDau")),
                                    NgayKetThuc = reader.GetDateTime(reader.GetOrdinal("NgayKetThuc")),
                                    IdTienLuong = reader.GetInt32(reader.GetOrdinal("IdTienLuong")),
                                    DuongDan=reader.GetString(reader.GetOrdinal("DuongDan")),
                                    MaNhanVien = reader.GetString(reader.GetOrdinal("MaNhanVien"))
                                };

                                NhanVienList.Add(nhanVien);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc dữ liệu từ cơ sở dữ liệu: " + ex.Message);
                MessageBox.Show("List nhan vien sai");
                return null;
            }

            return NhanVienList;
        }

        //Add User
        public int AddNV(string HoTen, string Email, string NgaySinh, string GioiTinh, string CMND, string DiaChi, string DangVien, string HocVan, string DuongDan)
        {
            int IdUser = -1; // Giá trị mặc định nếu không thêm được người dùng

            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "INSERT INTO Users(HoTen, NgaySinh, Email, GioiTinh, CMND, DiaChi, DangVien, HocVan, DuongDan) " +
                                   "VALUES (@HoTen, @NgaySinh, @Email, @GioiTinh, @CMND, @DiaChi, @DangVien, @HocVan, @DuongDan); " +
                                   "SELECT SCOPE_IDENTITY() AS IdUser;"; // Sửa cú pháp của câu lệnh SQL

                    using (cmd = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số và gán giá trị thực
                        cmd.Parameters.AddWithValue("@HoTen", HoTen);
                        cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                        cmd.Parameters.AddWithValue("@Email", Email);
                        cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                        cmd.Parameters.AddWithValue("@CMND", CMND);
                        cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                        cmd.Parameters.AddWithValue("@DangVien", DangVien);
                        cmd.Parameters.AddWithValue("@HocVan", HocVan);
                        cmd.Parameters.AddWithValue("@DuongDan", DuongDan);

                        // Thực thi câu lệnh và lấy giá trị Id
                        IdUser = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                return IdUser; // Trả về Id của người dùng mới được thêm
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm user: " + ex.Message);
                return -1; // Trả về -1 nếu có lỗi xảy ra
            }
        }

        //Add  nhanVien
        public void AddNV2(int IdUser, string MaNhanVien, string IdChucDanh, string IdTienLuong, string IdHopDong, string IdCongTac)
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "INSERT INTO NhanVien(IdUser, MaNhanVien, IdChucDanh, IdTienLuong, IdHopDong, IdCongTac) " +
                                   "VALUES (@IdUser, @MaNhanVien, @IdChucDanh, @IdTienLuong, @IdHopDong, @IdCongTac); ";

                    using (cmd = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số và gán giá trị thực
                        cmd.Parameters.AddWithValue("@IdUser", IdUser);
                        cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                        cmd.Parameters.AddWithValue("@IdChucDanh", IdChucDanh);
                        cmd.Parameters.AddWithValue("@IdTienLuong", IdTienLuong);
                        cmd.Parameters.AddWithValue("@IdHopDong", IdHopDong);
                        cmd.Parameters.AddWithValue("@IdCongTac", IdCongTac);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên2: " + ex.Message);
            }
        }



        //Dua Nhan vien
        public void AddNV2(int IdUser, string MaNhanVien, string IdChucDanh, string IdTienLuong, string IdHopDong, string IdCongTac)
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "INSERT INTO NhanVien(IdUser, MaNhanVien, IdChucDanh, IdTienLuong, IdHopDong, IdCongTac) " +
                                   "VALUES (@IdUser, @MaNhanVien, @IdChucDanh, @IdTienLuong, @IdHopDong, @IdCongTac); ";

                    using (cmd = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số và gán giá trị thực
                        cmd.Parameters.AddWithValue("@IdUser", IdUser);
                        cmd.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                        cmd.Parameters.AddWithValue("@IdChucDanh", IdChucDanh);
                        cmd.Parameters.AddWithValue("@IdTienLuong", IdTienLuong);
                        cmd.Parameters.AddWithValue("@IdHopDong", IdHopDong);
                        cmd.Parameters.AddWithValue("@IdCongTac", IdCongTac);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhân viên2: " + ex.Message);
            }
        }


    }
}

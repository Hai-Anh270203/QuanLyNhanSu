using Qlns.ConnectDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Qlns
{
    public partial class NV_HienThiTT1 : Form
    {
        public NV_HienThiTT1()
        {
            InitializeComponent();
        }

        private KetNoi ketNoi = new KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        private void NV_HienThiTT1_Load(object sender, EventArgs e)
        {
            Anhthe();
            txtMaNhanVien.Text = DangNhap.MaNhanVien;
            String ma = txtMaNhanVien.Text;

            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT Users.HoTen, Users.GioiTinh, Users.NgaySinh, Users.Email, Users.HocVan, " +
                              "Users.DangVien, Users.CMND, Users.DiaChi, CongTac.TenCongTac, ChucDanh.TenChucDanh, " +
                              "HopDong.NgayBatDau, Users.DuongDan, HopDong.LoaiHopDong, TienLuong.LuongCong " +
                              "FROM NhanVien " +
                              "JOIN Users ON NhanVien.IdUser = Users.Id " +
                              "JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id " +
                              "JOIN ChucDanh ON NhanVien.IdChucDanh = ChucDanh.Id " +
                              "JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id " +
                              "JOIN TienLuong ON NhanVien.IdTienLuong = TienLuong.Id " +
                              "WHERE MaNhanVien = N'" + ma + "'";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            txtHoTen.Text = reader["HoTen"].ToString();
                            txtGioiTinh.Text = reader["GioiTinh"].ToString();
                            txtNS.Text = reader["NgaySinh"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtHocVan.Text = reader["HocVan"].ToString();
                            txtDangVien.Text = reader["DangVien"].ToString();
                            txtCMND.Text = reader["CMND"].ToString();
                            txtDiaChi.Text = reader["DiaChi"].ToString();
                            txtCongTac.Text = reader["TenCongTac"].ToString();
                            txtCD.Text = reader["TenChucDanh"].ToString();
                            txtBatDau.Text = reader["NgayBatDau"].ToString();
                            txtHĐ.Text = reader["LoaiHopDong"].ToString();
                            txtLuong.Text = reader["LuongCong"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                        }

                        // Đóng reader sau khi sử dụng
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Anhthe()
        {
            txtMaNhanVien.Text = DangNhap.MaNhanVien;
            String ma = txtMaNhanVien.Text;
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT Users.HoTen, Users.GioiTinh, Users.NgaySinh, Users.Email, Users.HocVan, " +
                                      "Users.DangVien, Users.CMND, Users.DiaChi, CongTac.TenCongTac, ChucDanh.TenChucDanh, " +
                                      "HopDong.NgayBatDau, Users.DuongDan, HopDong.LoaiHopDong, TienLuong.LuongCong " +
                                      "FROM NhanVien " +
                                      "JOIN Users ON NhanVien.IdUser = Users.Id " +
                                      "JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id " +
                                      "JOIN ChucDanh ON NhanVien.IdChucDanh = ChucDanh.Id " +
                                      "JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id " +
                                      "JOIN TienLuong ON NhanVien.IdTienLuong = TienLuong.Id " +
                                      "WHERE MaNhanVien = @MaNhanVien";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                name.Text = reader["HoTen"].ToString();
                                // Đọc đường dẫn ảnh từ cơ sở dữ liệu
                                txtDuongDan.Text = reader["DuongDan"].ToString();
                                // Kiểm tra xem đường dẫn ảnh có tồn tại không
                                if (File.Exists(txtDuongDan.Text))
                                {
                                    // Tải ảnh từ đường dẫn và hiển thị nó trong PictureBox
                                    Image image = Image.FromFile(txtDuongDan.Text);
                                    PnAnh.Image = image;
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy ảnh!");
                                }

                                // Các dòng code khác ở đây
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

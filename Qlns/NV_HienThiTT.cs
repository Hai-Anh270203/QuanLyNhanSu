using Qlns.ConnectDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns
{
    public partial class NV_HienThiTT : Form
    {
        public NV_HienThiTT()
        {
            InitializeComponent();

        }
        private KetNoi ketNoi = new KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        string chuanhoa = string.Empty;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

        private void NV_HienThiTT_Load(object sender, EventArgs e)
        {
            txtMaNv.Text = DangNhap.MaNhanVien;
            String ma = txtMaNv.Text;

            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT Users.HoTen, Users.GioiTinh, Users.NgaySinh, Users.Email, Users.HocVan, " +
                  "Users.DangVien, Users.CMND, Users.DiaChi, CongTac.TenCongTac, ChucDanh.TenChucDanh, HopDong.NgayBatDau, Users.DuongDan " +
                  "FROM NhanVien " +
                  "JOIN Users ON NhanVien.IdUser = Users.Id " +
                  "JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id " +
                  "JOIN ChucDanh ON NhanVien.IdChucDanh = ChucDanh.Id " +
                  "JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id " +
                  "WHERE MaNhanVien = N'" + ma + "'";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột
                            
                            hovaten.Text = reader["HoTen"].ToString();
                            gioitinh.Text = reader["GioiTinh"].ToString();
                            ngaysinh.Text = reader["NgaySinh"].ToString();
                            email.Text = reader["Email"].ToString();
                            hocvan.Text = reader["HocVan"].ToString();
                            dangvien.Text = reader["DangVien"].ToString();
                            cccd.Text = reader["CMND"].ToString();
                            diachi.Text = reader["DiaChi"].ToString();
                            congtac.Text = reader["TenCongTac"].ToString();
                            chucdanh.Text = reader["TenChucDanh"].ToString();
                            vaolam.Text = reader["NgayBatDau"].ToString();
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
    }
}

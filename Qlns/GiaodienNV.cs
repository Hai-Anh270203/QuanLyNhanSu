using FontAwesome.Sharp;
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
using System.IO;

namespace Qlns
{
    public partial class GiaodienNV : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private KetNoi ketNoi = new KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        public GiaodienNV()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

       
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }

        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }
        private void OpenFormInPanel(object ChildForm)
        {
            // Kiểm tra nếu Panel chứa các điều khiển (controls) đã có
            if (this.Container.Controls.Count > 0)
                this.Container.Controls.RemoveAt(0);

            // Ép kiểu đối tượng con thành kiểu Form
            Form childForm = ChildForm as Form;

            // Đặt đối tượng con không phải là TopLevel để có thể chứa nó trong Panel
            childForm.TopLevel = false;

            // Đặt thuộc tính Dock của đối tượng con để điền vào toàn bộ kích thước của Panel
            childForm.Dock = DockStyle.Fill;

            // Thêm đối tượng con vào Panel
            this.Container.Controls.Add(childForm);

            // Gắn Tag cho Panel để lưu trữ thông tin về đối tượng con
            this.Container.Tag = childForm;

            // Hiển thị đối tượng con
            childForm.Show();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new NV_HienThiTT1());
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new NV_ChamCong());
        }

        private void btnTongluong_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new NV_TongLuong());
        }

        private void btnKhenThuong_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new NV_KhenThuong());
        }

        private void btnKiLuat_Click_1(object sender, EventArgs e)
        {
            OpenFormInPanel(new NV_KiLuat());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Hiển thị form đăng nhập hoặc form khác để người dùng đăng nhập lại
            DangNhap loginForm = new DangNhap();
            loginForm.Show();

            // Đóng form hiện tại
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void GiaodienNV_Load(object sender, EventArgs e)
        {
            Anhthe();
        }
        private void Anhthe()
        {
            String ma = DangNhap.MaNhanVien;
             
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
                                      "WHERE MaNhanVien = N'"+ma+"'";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ten.Text = reader["HoTen"].ToString();
                                label2.Text = reader["TenCongTac"].ToString();
                                // Đọc đường dẫn ảnh từ cơ sở dữ liệu
                                txtDuongDan.Text = reader["DuongDan"].ToString();
                                // Kiểm tra xem đường dẫn ảnh có tồn tại không
                                if (File.Exists(txtDuongDan.Text))
                                {
                                    // Tải ảnh từ đường dẫn và hiển thị nó trong PictureBox
                                    Image image = Image.FromFile(txtDuongDan.Text);
                                    anh.Image = image;
                                    daidien.Image = image;
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

        private void anh_Click(object sender, EventArgs e)
        {

        }

        private void ten_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
using FontAwesome.Sharp;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Qlns.ConnectDB;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Qlns
{
    public partial class GiaoDien : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private KetNoi ketNoi = new KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        public GiaoDien()
        {
            InitializeComponent();

            //Chart
            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new LiveCharts.Defaults.ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),
                        new ObservablePoint(2,5),
                        new ObservablePoint(3,6),
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),
                        new ObservablePoint(2,5),
                        new ObservablePoint(3,6),
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },
            };
            //Chart


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Methods
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(108, 72, 135);
            public static Color color2 = Color.FromArgb(108, 72, 135);
            public static Color color3 = Color.FromArgb(108, 72, 135);
            public static Color color4 = Color.FromArgb(108, 72, 135);
            public static Color color5 = Color.FromArgb(108, 72, 135);
            public static Color color6 = Color.FromArgb(108, 72, 135);
            public static Color color7 = Color.FromArgb(108, 72, 135);
            public static Color color8 = Color.FromArgb(108, 72, 135);

        }
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
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
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

        private void OpenFormInPanel(Form childForm)
        {
            // Kiểm tra nếu có form con đang hiển thị, đóng form đó trước khi hiển thị form mới
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            // Thiết lập các thuộc tính cho form con
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Gắn form con vào container
            this.Container.Controls.Add(childForm);
            this.Container.Tag = childForm;

            // Hiển thị form con
            childForm.BringToFront();
            childForm.Show();

            // Lưu trữ tham chiếu đến form con hiện tại
            currentChildForm = childForm;
        }


        private void btnNV_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new NhanVien());
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BoPhan1());

        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ChamCong1());
        }

        private void BL_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new TienLuong());
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BCTK());
        }

        private void btnTCTT_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Tracuu1());
        }

        private void btnHT_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new FormHeThong1());
        }

        private void iconButton1_Click(object sender, EventArgs e)
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

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new BaoHiem());
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
                                      "WHERE MaNhanVien = N'" + ma + "'";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ten.Text = reader["HoTen"].ToString();
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

        private void GiaoDien_Load(object sender, EventArgs e)
        {
            Anhthe();
            TongNhanVien();
            NVSinhnhat();
            Nam();
            Nu();
            HienThiBieuDoPie();
        }
        private void TongNhanVien()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS TongNV FROM NhanVien WHERE NhanVien.Status = 1;";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            txtTongnv.Text = reader["TongNV"].ToString();

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
        private void NVSinhnhat()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS sinhnhat FROM Users JOIN NhanVien ON NhanVien.IdUser = Users.Id WHERE NhanVien.Status = 1 AND DATEPART(MONTH, Users.NgaySinh) = DATEPART(MONTH, GETDATE());";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            txtBirth.Text = reader["sinhnhat"].ToString();

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
        private void Nam()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS Nam FROM Users JOIN NhanVien ON NhanVien.IdUser = Users.Id WHERE NhanVien.Status = 1 AND GioiTinh=N'Nam';";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            nam.Text = reader["Nam"].ToString();

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
        private void Nu()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS NU FROM Users JOIN NhanVien ON NhanVien.IdUser = Users.Id WHERE NhanVien.Status = 1 AND GioiTinh=N'Nữ';";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            nu.Text = reader["NU"].ToString();

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
        private void HienThiBieuDoPie()
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT " +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac LIKE '%Marketing%') AS Marketing," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac LIKE '%IT%') AS IT," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac=N'Kế toán') AS Ketoan," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac= N'Nhân sự') AS NS," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac= N'Sales') AS Sales;";
                    using (cmd = new SqlCommand(query, connection))
                    {
                        reader = cmd.ExecuteReader();

                        // Xóa các chuỗi dữ liệu cũ (nếu có) và thêm chuỗi dữ liệu mới cho biểu đồ pie
                        System.Windows.Forms.DataVisualization.Charting.Series dataSeries = new System.Windows.Forms.DataVisualization.Charting.Series("NhanVienData");
                        dataSeries.ChartType = SeriesChartType.Pie;

                        while (reader.Read())
                        {
                            // Lấy số lượng nhân viên theo từng loại hợp đồng và nhân viên nghỉ việc
                            int Marketing = reader.GetInt32(reader.GetOrdinal("Marketing"));
                            int IT = reader.GetInt32(reader.GetOrdinal("IT"));
                            int ketoan = reader.GetInt32(reader.GetOrdinal("Ketoan"));
                            int NS = reader.GetInt32(reader.GetOrdinal("NS"));
                            int Sales = reader.GetInt32(reader.GetOrdinal("Sales"));

                            // Thêm các điểm dữ liệu vào chuỗi dữ liệu của biểu đồ pie
                            dataSeries.Points.AddXY("Marketing", Marketing);
                            dataSeries.Points.AddXY("IT", IT);
                            dataSeries.Points.AddXY("Kế toán", ketoan);
                            dataSeries.Points.AddXY("Nhân sự", NS);
                            dataSeries.Points.AddXY("Sales", Sales);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu biểu đồ: " + ex.Message);
            }
            finally
            {
                // Đảm bảo rằng kết nối đã được đóng sau khi sử dụng
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

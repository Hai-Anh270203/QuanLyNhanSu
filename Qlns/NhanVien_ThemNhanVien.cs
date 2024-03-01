using Qlns.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Qlns
{
    public partial class NhanVien_ThemNhanVien : Form
    {
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        int IdHopDong;
     

        public NhanVien_ThemNhanVien()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void PnAnh_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn tệp để lấy đường dẫn ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.bmp)|*.jpg; *.png; *.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp đã chọn
                string imagePath = openFileDialog.FileName;

                try
                {
                    // Tạo một đối tượng Image từ đường dẫn
                    Image image = Image.FromFile(imagePath);
                    // Hiển thị ảnh trong PictureBox
                    PnAnh.Image = image;
                    txtDuongDan.Text=imagePath.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đọc ảnh. Lỗi: " + ex.Message);
                }
            }
        }

        private void NhanVien_ThemNhanVien_Load(object sender, EventArgs e)
        {
            //lay thoi gian hien tai
            DateTime ThoiGian = DateTime.Now;
            string formatTime = ThoiGian.ToString("yyyyMMddHHmmss");
            txtMaNhanVien.Text = formatTime.ToString();
            // Load combobox ChucDanh
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM ChucDanh";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);

                    // Assuming you have a ComboBox named CbMaSach
                    CbChucDanh.DataSource = datatable;
                    CbChucDanh.DisplayMember = "TenChucDanh"; // Corrected column name
                    CbChucDanh.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //load CongTac
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM CongTac";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Thiết lập dữ liệu cho ComboBox
                    CbCongTac.DataSource = dataTable;
                    CbCongTac.DisplayMember = "TenCongTac";
                    CbCongTac.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //Load Hop Dong
            try
            {
                using(connection=kn.OpenConnection())
                {
                    string query = "SELECT HopDong.LoaiHopDong FROM HopDong";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    CbLoaiHopDong.DisplayMember="LoaiHopDong";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Load tien luong
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM TienLuong";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CbMaLuong.DataSource = dataTable;
                    CbMaLuong.DisplayMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HopDongDAL hopDongDAL = new HopDongDAL();
            IdHopDong = hopDongDAL.AddHopDong(CbLoaiHopDong.Text, DtNgayBatDau.Text, DtNgayKetThuc.Text);

            Provide.LuuAnh luuAnh = new Provide.LuuAnh();
            string D = luuAnh.KtraAnh(txtDuongDan.Text);
            luuAnh.LuuAnhMoi(txtDuongDan.Text);


            //tHEM uSER
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            int IdUser = nhanVienDAL.AddNV(txtHoTen.Text, txtEmail.Text, DtNgaySinh.Text, CbGioiTinh.Text, txtCMND.Text, txtDiaChi.Text, CbDangVien.Text, CbHocVan.Text, D);
            MessageBox.Show(IdUser.ToString());
            //Them nhan Vien
            NhanVienDAL nhanvien = new NhanVienDAL();
            nhanvien.AddNV2(IdUser, txtMaNhanVien.Text, CbChucDanh.SelectedValue.ToString(), CbMaLuong.Text, IdHopDong.ToString(), CbCongTac.SelectedValue.ToString());



            /*   try
               {
                   nhanvien.AddNV2(1, "1", "1", "1", "1", "1");

               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }*/


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
         }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

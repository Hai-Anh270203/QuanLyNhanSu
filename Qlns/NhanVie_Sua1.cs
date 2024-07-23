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

namespace Qlns
{
    public partial class NhanVie_Sua1 : Form
    {
        string _HoTen;
        string _IdUser;
        string _NgaySinh;
        string _Email;
        string _GioiTinh;
        string _DiaChi;
        string _DangVien;
        string _HocVan;
        string _CMND;
        string _DuongDan;
        string _TenChucDanh;
        string _TenCongTac;
        string _LoaiHopDong;
        string _IdHopDong;
        string _NgayBatDau;
        string _NgayKetThuc;
        string _IdTienLuong;
        string _MaNhanVien;

        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        public NhanVie_Sua1(string IdUser, string HoTen, string NgaySinh, string Email, string GioiTinh, string DiaChi, string DangVien, string HocVan
            , string CMND, string DuongDan, string TenChucDanh, string TenCongTac, string LoaiHopDong, string IdHopDong
            , string NgayBatDau, string NgayKetThuc, string IdTienLuong, string MaNhanVien)
        {
            _HoTen = HoTen;
            _Email = Email;
            _IdUser = IdUser;
            _NgaySinh = NgaySinh;
            _Email = Email;
            _GioiTinh = GioiTinh;
            _DiaChi = DiaChi;
            _DangVien = DangVien;
            _HocVan = HocVan;
            _CMND = CMND;
            _DuongDan = DuongDan;
            _TenChucDanh = TenChucDanh;
            _TenCongTac = TenCongTac;
            _LoaiHopDong = LoaiHopDong;

            _IdHopDong = IdHopDong;
            _NgayBatDau = NgayBatDau;
            _NgayKetThuc = NgayKetThuc;
            _IdTienLuong = IdTienLuong;
            _MaNhanVien = MaNhanVien;



            _NgaySinh = NgaySinh;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVie_Sua1_Load(object sender, EventArgs e)
        {


            // Load combobox ChucDanh
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM ChucDanh where ChucDanh.Status = '1'";
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
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT HopDong.LoaiHopDong FROM HopDong";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    CbLoaiHopDong.DisplayMember = "LoaiHopDong";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Load tien luong
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM TienLuong where TienLuong.Status = '1'";
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

            txtHoTen.Text = _HoTen;
            txtEmail.Text = _Email;
            DtNgaySinh.Text = _NgaySinh;

            CbGioiTinh.Text = _GioiTinh;
            txtDiaChi.Text = _DiaChi;
            CbDangVien.Text = _DangVien;
            CbHocVan.Text = _HocVan;
            txtCMND.Text = _CMND;
            txtDuongDan.Text = _DuongDan;
            CbChucDanh.Text = _TenChucDanh;
            CbCongTac.Text = _TenCongTac;
            CbLoaiHopDong.Text = _LoaiHopDong;
            DtNgayBatDau.Text = _NgayBatDau;
            DtNgayBatDau.Text = _NgayKetThuc;
            CbMaLuong.Text = _IdTienLuong;
            txtMaNhanVien.Text = _MaNhanVien;

            Image image = Image.FromFile(_DuongDan);
            // Hiển thị ảnh trong PictureBox
            PnAnh.Image = image;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //Sua Anh]
            Provide.LuuAnh luuAnh = new Provide.LuuAnh();
            string D = luuAnh.KtraAnh(txtDuongDan.Text);
            luuAnh.LuuAnhMoi(txtDuongDan.Text);
            //sua hop dong
            DAL.HopDongDAL hopDongDAL = new DAL.HopDongDAL();
            hopDongDAL.SuaHopDong(CbLoaiHopDong.Text, DtNgayBatDau.Text, DtNgayKetThuc.Text, _IdHopDong);


            //Sua nhan vien
            DAL.NhanVienDAL nhanVienDAL = new DAL.NhanVienDAL();
            nhanVienDAL.SuaNhanVien(_IdUser, CbChucDanh.SelectedValue.ToString(), CbMaLuong.Text, _IdHopDong, CbCongTac.SelectedValue.ToString());

            //Sua User
            DAL.NhanVienDAL nhanVienDAL1 = new DAL.NhanVienDAL();
            nhanVienDAL1.SuaUser(_IdUser, txtHoTen.Text, DtNgaySinh.Text, txtEmail.Text, CbGioiTinh.Text, txtCMND.Text, txtDiaChi.Text, CbDangVien.Text, CbHocVan.Text, D);
            MessageBox.Show("Sua thanh cong ");
            this.Close();
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
                    txtDuongDan.Text = imagePath.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể đọc ảnh. Lỗi: " + ex.Message);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

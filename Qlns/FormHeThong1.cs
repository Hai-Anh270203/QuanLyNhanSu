using Qlns.DAL;
using Qlns.DTO;
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
    public partial class FormHeThong1 : Form
    {
        public FormHeThong1()
        {
            InitializeComponent();
        }
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;

        string _MNV;
        string _HoTen;
        string _IdUser;
        string _IdUserRole;

        private void FormHeThong1_Load(object sender, EventArgs e)
        {
            //Load datagridview
            DGVHeThong.AutoGenerateColumns = false;

            // Khởi tạo một đối tượng BindingList để lưu trữ danh sách nhân viên
            List<TaiKhoanDTO> TkList = new List<TaiKhoanDTO>();

            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                TaiKhoanDAL TKDAL = new TaiKhoanDAL();
                TkList = new List<TaiKhoanDTO>(TKDAL.GetTkList());

                // Gán danh sách nhân viên vào DataSource của DataGridView
                DGVHeThong.DataSource = TkList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }

            //Load Quyen
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM Role";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    CbQuyen.DataSource = dataTable;
                    CbQuyen.DisplayMember = "Role";
                    CbQuyen.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

            DGVHeThong.AutoGenerateColumns = false;

            // Khởi tạo một đối tượng BindingList để lưu trữ danh sách nhân viên
            List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();

            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                TaiKhoanDAL TKDAL = new TaiKhoanDAL();
                txtHoTen.Text = TKDAL.SearchTaiKhoan(txtMaNhanVien.Text);
                /*                nhanVienDTOs = new List<NhanVienDTO>(nhanVienDAL.SearchTenNhanVienList(txtTenNhanVien.Text));
                */
                // Gán danh sách nhân viên vào DataSource của DataGridView
                /*                DGVNhanVien.DataSource = nhanVienDTOs;
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            bool MatKhauHopLe = string.Equals(txtMk.Text, txtXacNhanMK.Text);
            if (MatKhauHopLe)
            {
                Provide.pass maHoaMK = new Provide.pass();
                string MatKhauMaHoa = maHoaMK.HashPassword(txtMk.Text);
                // Thêm tài khoản với mật khẩu đã mã hóa vào cơ sở dữ liệu
                TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
                taiKhoanDAL.ThemTaiKhoan(txtMaNhanVien.Text, MatKhauMaHoa, CbQuyen.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp nhau. Vui lòng nhập lại mật khẩu.");
            }
            /*else
            {
                bool MatKhauDung = maHoaMK.GiaiMa(txtXacNhanMK.Text, txtMk.Text);
                if(MatKhauDung)
                {
                    MessageBox.Show("Mật khẩu hợp lệ.");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không hợp lệ.");
                }
            }*/
        }


        private void DGVHeThong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)

            {
                // Lấy dữ liệu từ ô của hàng đó
                DataGridViewRow selectedRow = DGVHeThong.Rows[e.RowIndex];

                // Lấy giá trị từ các ô của hàng đó và gán vào các biến tương ứng
                _MNV = selectedRow.Cells["MaNhanVien"].Value.ToString();
                _IdUser = selectedRow.Cells["IdUser"].Value.ToString();
                _HoTen = selectedRow.Cells["HoTen"].Value.ToString();
                _IdUserRole = selectedRow.Cells["IdUserRole"].Value.ToString();
                txtHoTen.Text = _HoTen;
                txtMaNhanVien.Text = _MNV;

            }
            else
            {
                // Nếu không có hàng nào được chọn, hiển thị một thông báo cảnh báo
                MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            Provide.pass maHoaMK = new Provide.pass();
            string MatKhauMaHoa = maHoaMK.HashPassword(txtMk.Text);
            DAL.TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            taiKhoanDAL.SuaTK(_IdUser, MatKhauMaHoa, _IdUserRole, CbQuyen.SelectedValue.ToString());
        }

        private void BtnNhapLai_Click(object sender, EventArgs e)
        {
            //Load datagridview
            DGVHeThong.AutoGenerateColumns = false;

            // Khởi tạo một đối tượng BindingList để lưu trữ danh sách nhân viên
            List<TaiKhoanDTO> TkList = new List<TaiKhoanDTO>();

            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                TaiKhoanDAL TKDAL = new TaiKhoanDAL();
                TkList = new List<TaiKhoanDTO>(TKDAL.GetTkList());

                // Gán danh sách nhân viên vào DataSource của DataGridView
                DGVHeThong.DataSource = TkList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DAL.TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
            taiKhoanDAL.XoaTK(_IdUserRole);
        }
    }
}

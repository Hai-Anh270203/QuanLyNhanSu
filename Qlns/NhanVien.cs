using Qlns.DAL;
using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns
{
    public partial class NhanVien : Form
    {
        string User;
        string MaNhanVien;
        string TenNhanVien;
        string NgaySinh;
        string GioiTinh;
        string Email;
        string DiaChi;
        string DangVien;
        string HocVan;
        string CMND;
        string TenChucDanh;
        string HopDong;
        string MaTienLuong;
        string TenCongTac;
        string BatDau;
        string KetThuc;
        string DuongDan;

        public NhanVien()
        {
            InitializeComponent();
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            DGVNhanVien.AutoGenerateColumns = false;

            // Khởi tạo một đối tượng BindingList để lưu trữ danh sách nhân viên
            List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();

            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                nhanVienDTOs = new List<NhanVienDTO>(nhanVienDAL.GetNhanVienList());

                // Gán danh sách nhân viên vào DataSource của DataGridView
                DGVNhanVien.DataSource = nhanVienDTOs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }

           
        }


        private void DGVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tadNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DAL.NhanVienDAL nhanVienDAL=new DAL.NhanVienDAL();
            List<DTO.NhanVienDTO> NhanVienList = nhanVienDAL.GetNhanVienList();
            if(NhanVienList != null )
            {
                DGVNhanVien.DataSource= NhanVienList;
           /*     DGVNhanVien.AutoGenerateColumns = true;*/
            }
            else
            {
                MessageBox.Show("Không thể lấy danh sách nhân viên");
            }
        }

        private void DGVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem người dùng đã chọn một hàng hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)

            {
                // Lấy dữ liệu từ ô của hàng đó
                DataGridViewRow selectedRow = DGVNhanVien.Rows[e.RowIndex];

                // Lấy giá trị từ các ô của hàng đó và gán vào các biến tương ứng
                User = selectedRow.Cells["jl"].Value.ToString();
                MaNhanVien = selectedRow.Cells["MNV"].Value.ToString();
                TenNhanVien = selectedRow.Cells["HT"].Value.ToString();
                NgaySinh = selectedRow.Cells["NS"].Value.ToString();
                GioiTinh = selectedRow.Cells["GT"].Value.ToString();
                Email = selectedRow.Cells["E"].Value.ToString();
                DiaChi = selectedRow.Cells["DC"].Value.ToString();
                DangVien = selectedRow.Cells["DV"].Value.ToString();
                HocVan = selectedRow.Cells["HV"].Value.ToString();
                CMND = selectedRow.Cells["nameCMND"].Value.ToString();
                TenChucDanh = selectedRow.Cells["TCD"].Value.ToString();
                HopDong = selectedRow.Cells["LoaiHopDong"].Value.ToString();
                MaTienLuong = selectedRow.Cells["TienLuong"].Value.ToString();
                TenCongTac = selectedRow.Cells["TCT"].Value.ToString();
                BatDau = selectedRow.Cells["NgayBatDau"].Value.ToString();
                KetThuc = selectedRow.Cells["NgayKetThuc"].Value.ToString();
                DuongDan = selectedRow.Cells["DuongDa"].Value.ToString();
                // Kiểm tra xem đường dẫn có tồn tại không
                if (File.Exists(DuongDan))
                {
                    // Tải hình ảnh từ đường dẫn và gán cho PictureBox
                    PAnh.Image = Image.FromFile(DuongDan);
                }
                else
                {
                    // Nếu không tìm thấy hình ảnh, hiển thị một hình ảnh mặc định hoặc thông báo khác
                    MessageBox.Show("Không tìm thấy hình ảnh.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Nếu không có hàng nào được chọn, hiển thị một thông báo cảnh báo
                MessageBox.Show("Vui lòng chọn một hàng để xem chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien_ThemNhanVien nhanVien_ThemNhanVien = new NhanVien_ThemNhanVien();
            nhanVien_ThemNhanVien.Show();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void PAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using Qlns.DAL;
using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using Excel = Microsoft.Office.Interop.Excel;
*/

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
        string IdCongTac;
        string IdChucDanh;
        string IdHopDong;

        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            DGVNhanVien.AutoGenerateColumns = false;
/*            DGVNhanVien.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
*/
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
            //load form nghỉ hưu
            DGVNghihuu.AutoGenerateColumns = false;

            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                nhanVienDTOs = new List<NhanVienDTO>(nhanVienDAL.NVNghiHuu());

                // Gán danh sách nhân viên vào DataSource của DataGridView
                DGVNghihuu.DataSource = nhanVienDTOs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }

            //Load form sinh nhật
            DGVSinhNhat.AutoGenerateColumns = false;
            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                nhanVienDTOs = new List<NhanVienDTO>(nhanVienDAL.SinhNhatNV());

                // Gán danh sách nhân viên vào DataSource của DataGridView
                DGVSinhNhat.DataSource = nhanVienDTOs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }


        }


        private void DGVNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một hàng hay không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)

            {
                // Lấy dữ liệu từ ô của hàng đó
                DataGridViewRow selectedRow = DGVNhanVien.Rows[e.RowIndex];

                // Lấy giá trị từ các ô của hàng đó và gán vào các biến tương ứng
                User = selectedRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                MaNhanVien = selectedRow.Cells["dataGridViewTextBoxColumn5"].Value.ToString();
                TenNhanVien = selectedRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
                NgaySinh = selectedRow.Cells["dataGridViewTextBoxColumn7"].Value.ToString();
                GioiTinh = selectedRow.Cells["dataGridViewTextBoxColumn8"].Value.ToString();
                Email = selectedRow.Cells["dataGridViewTextBoxColumn9"].Value.ToString();
                DiaChi = selectedRow.Cells["dataGridViewTextBoxColumn10"].Value.ToString();
                DangVien = selectedRow.Cells["dataGridViewTextBoxColumn11"].Value.ToString();
                HocVan = selectedRow.Cells["dataGridViewTextBoxColumn12"].Value.ToString();
                CMND = selectedRow.Cells["dataGridViewTextBoxColumn13"].Value.ToString();
                TenChucDanh = selectedRow.Cells["dataGridViewTextBoxColumn14"].Value.ToString();
                HopDong = selectedRow.Cells["dataGridViewTextBoxColumn15"].Value.ToString();
          

                MaTienLuong = selectedRow.Cells["dataGridViewTextBoxColumn16"].Value.ToString();
                TenCongTac = selectedRow.Cells["dataGridViewTextBoxColumn17"].Value.ToString();
                BatDau = selectedRow.Cells["dataGridViewTextBoxColumn3"].FormattedValue.ToString();

                KetThuc = selectedRow.Cells["dataGridViewTextBoxColumn18"].Value.ToString();
                DuongDan = selectedRow.Cells["dataGridViewTextBoxColumn4"].Value.ToString();
                IdHopDong = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();

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


        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            DGVNhanVien.AutoGenerateColumns = false;

            // Khởi tạo một đối tượng BindingList để lưu trữ danh sách nhân viên
            List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();

            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                nhanVienDTOs = new List<NhanVienDTO>(nhanVienDAL.SearchNhanVienList(txtMaNhanVien.Text));

                // Gán danh sách nhân viên vào DataSource của DataGridView
                DGVNhanVien.DataSource = nhanVienDTOs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            DGVNhanVien.AutoGenerateColumns = false;

            // Khởi tạo một đối tượng BindingList để lưu trữ danh sách nhân viên
            List<NhanVienDTO> nhanVienDTOs = new List<NhanVienDTO>();

            try
            {
                // Tạo một đối tượng của lớp NhanVienDAL để gọi phương thức GetNhanVienList() và lấy danh sách nhân viên
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                nhanVienDTOs = new List<NhanVienDTO>(nhanVienDAL.SearchTenNhanVienList(txtTenNhanVien.Text));

                // Gán danh sách nhân viên vào DataSource của DataGridView
                DGVNhanVien.DataSource = nhanVienDTOs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải danh sách nhân viên: " + ex.Message);
            }
        }

     

        private void btnThemBH_Click(object sender, EventArgs e)
        {
            ThemBaoHiem1 themBaoHiem = new ThemBaoHiem1();
            themBaoHiem.Show();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }


        private void btnExcel_Click(object sender, EventArgs e)
        {
          /*  Microsoft.Office.Interop.Excel.Application excel;
            if (DGVNhanVien.Rows.Count > 0)
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DGVNhanVien.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = DGVNhanVien.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DGVNhanVien.Rows.Count; i++)
                {
                    for (int j = 0; j < DGVNhanVien.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DGVNhanVien.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }*/
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien_ThemNhanVien1 nhanVien_ThemNhanVien = new NhanVien_ThemNhanVien1();
            nhanVien_ThemNhanVien.Show();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVie_Sua1 nhanVien_Sua = new NhanVie_Sua1(User, TenNhanVien, NgaySinh, Email, GioiTinh, DiaChi, DangVien, HocVan, CMND, DuongDan, TenChucDanh, TenCongTac, HopDong, IdHopDong, BatDau, KetThuc, MaTienLuong, MaNhanVien);
            nhanVien_Sua.Show();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                NhanVienDAL nhanVienDAL1 = new NhanVienDAL();
                nhanVienDAL1.XoaNV(User);
            }
            else
            {
                // Xử lý khi người dùng chọn "Không"
            }

            DAL.NhanVienDAL nhanVienDAL = new NhanVienDAL();
        }

        private void btnMoi_Click(object sender, EventArgs e)
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
        //Nhân viên nghỉ hưu

        private void btnExNghihuu_Click(object sender, EventArgs e)
        {
          /*  Microsoft.Office.Interop.Excel.Application excel;
            if (DGVNghihuu.Rows.Count > 0)
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DGVNghihuu.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = DGVNghihuu.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DGVNghihuu.Rows.Count; i++)
                {
                    for (int j = 0; j < DGVNghihuu.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DGVNghihuu.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }*/
        }

        private void btnExSinhNhat_Click(object sender, EventArgs e)
        {
           /* Microsoft.Office.Interop.Excel.Application excel;
            if (DGVSinhNhat.Rows.Count > 0)
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DGVSinhNhat.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = DGVSinhNhat.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DGVSinhNhat.Rows.Count; i++)
                {
                    for (int j = 0; j < DGVSinhNhat.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DGVSinhNhat.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }*/
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            
        }

        // nhân viên sinh nhật




    }
}

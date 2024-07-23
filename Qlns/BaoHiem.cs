using Qlns.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns
{
    public partial class BaoHiem : Form
    {
        public BaoHiem()
        {
            InitializeComponent();
        }
        private void BaoHiem_Load(object sender, EventArgs e)
        {
            BaoHiemDAL GoiBaoHiem = new BaoHiemDAL();
            List<DTO.BaoHiemDTO> DsBaoHiem = GoiBaoHiem.LayBaoHiem();
            DgvBaoHiem.DataSource = DsBaoHiem;
            DgvBaoHiem.AutoGenerateColumns = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemBaoHiem1 themBaoHiem = new ThemBaoHiem1();
            themBaoHiem.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            // Chuyển đổi giá trị ngày từ DateTimePicker sang chuỗi đúng định dạng
            string ngayCap = DateNgayCap.Value.ToString("yyyy/MM/dd");
            int IdBaoHiem = int.Parse(txtMaBH.Text);

            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            // Lấy các giá trị từ các điều khiển trên giao diện và truyền vào phương thức ThemBaoHiem
            BaoHiemDAL baoHiemDAL = new BaoHiemDAL();
            baoHiemDAL.SuaBaoHiem(IdBaoHiem, ngayCap, txtGhiChu.Text, Convert.ToInt32(txtTienBaoHiem.Text), Convert.ToInt32(txtMaNV.Text), txtNoiCap.Text);
            BaoHiem_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int IdBaoHiem = int.Parse(txtMaBH.Text);
            int Status = 0; // Giả sử bạn muốn đặt status = 0 khi xóa công tác
            BaoHiemDAL baoHiemDAL = new BaoHiemDAL();
            baoHiemDAL.XoaBaoHiem(IdBaoHiem, Status);
            BaoHiem_Load(sender, e);
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            BaoHiemDAL GoiBaoHiem = new BaoHiemDAL();
            List<DTO.BaoHiemDTO> DsBaoHiem = GoiBaoHiem.LayBaoHiem();
            DgvBaoHiem.DataSource = DsBaoHiem;
            DgvBaoHiem.AutoGenerateColumns = false;
        }

        private void DgvBaoHiem_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBaoHiem.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn đầu tiên
                DataGridViewRow selectedRow = DgvBaoHiem.SelectedRows[0];

                // Lấy giá trị từ cột "TenChucDanh" của dòng được chọn
                string TienBaoHiem = selectedRow.Cells["TienBaoHiem"].Value.ToString();
                string NgayCap = selectedRow.Cells["NgayCap"].FormattedValue.ToString();
                string NoiCap = selectedRow.Cells["NoiCap"].Value.ToString();
                string GhiChu = selectedRow.Cells["GhiChu"].Value.ToString();
                string Id = selectedRow.Cells["Id"].Value.ToString();
                string IdNhanVien = selectedRow.Cells["IdNhanVien"].Value.ToString();


                // Lấy chỉ ngày, tháng, năm từ parsedDate và gán cho DateNgayCap
                DateNgayCap.Text = NgayCap;
                txtTienBaoHiem.Text = TienBaoHiem;
                txtNoiCap.Text = NoiCap;
                txtGhiChu.Text = GhiChu;
                txtMaNV.Text = IdNhanVien;
                txtMaBH.Text = Id;

            }
        }

        private void DgvBaoHiem_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DgvBaoHiem.Rows[e.RowIndex].Selected = true;
                foreach (DataGridViewCell cell in DgvBaoHiem.Rows[e.RowIndex].Cells)
                {
                    cell.Selected = true;
                }
            }
        }
    }
}

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
    public partial class BoPhan1 : Form
    {
        public BoPhan1()
        {
            InitializeComponent();
        }

        private void BoPhan1_Load(object sender, EventArgs e)
        {
            ChucDanhDAL GoiChucDanh = new ChucDanhDAL();
            List<DTO.ChucDanhDTO> DsChucDanh = GoiChucDanh.LayChucDanh();
            DgvCD.AutoGenerateColumns = false;
            DgvCD.DataSource = DsChucDanh;
            

            CongTacDAL GoiCongTac = new CongTacDAL();
            List<DTO.CongTacDTO> DsCongTac = GoiCongTac.LayCongTac();
            DgvCD.AutoGenerateColumns = false;
            DGV_CongTac.DataSource = DsCongTac;
            



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemCD cD = new ThemCD();
            cD.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int chucDanhId = int.Parse(txtMaChucDanh.Text);
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.SuaChucDanh(chucDanhId, txtTenChucDanh.Text);
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            ChucDanhDAL GoiChucDanh = new ChucDanhDAL();
            List<DTO.ChucDanhDTO> DsChucDanh = GoiChucDanh.LayChucDanh();
            DgvCD.DataSource = DsChucDanh;
            DgvCD.AutoGenerateColumns = true;
        }

       

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            ThemCT themCT = new ThemCT();
            themCT.ShowDialog();
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            int congtacID = int.Parse(txtMaCongTac.Text);
            CongTacDAL congTacDAL = new CongTacDAL();
            congTacDAL.SuaCongTac(congtacID, txtTenCongTac.Text);
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            int congtacID = int.Parse(txtMaCongTac.Text);
            int Status = 0; // Giả sử bạn muốn đặt status = 0 khi xóa công tác
            CongTacDAL congTacDAL = new CongTacDAL();
            congTacDAL.XoaCongTac(congtacID, Status);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CongTacDAL GoiCongTac = new CongTacDAL();
            List<DTO.CongTacDTO> DsCongTac = GoiCongTac.LayCongTac();
            DGV_CongTac.DataSource = DsCongTac;
            DGV_CongTac.AutoGenerateColumns = true;
        }

        private void DGV_CongTac_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_CongTac.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn đầu tiên
                DataGridViewRow selectedRow = DGV_CongTac.SelectedRows[0];

                // Lấy giá trị từ cột "TenChucDanh" của dòng được chọn
                string MaCongTac = selectedRow.Cells["MaCongTac"].Value.ToString();
                string tenChucDanh = selectedRow.Cells["TenCongTac"].Value.ToString();

                // Gán giá trị vào TextBox
                txtTenCongTac.Text = tenChucDanh;
                txtMaCongTac.Text = MaCongTac;
            }
        }

        private void DgvCD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DGV_CongTac.Rows[e.RowIndex].Selected = true;
                foreach (DataGridViewCell cell in DGV_CongTac.Rows[e.RowIndex].Cells)
                {
                    cell.Selected = true;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void DGV_CongTac_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DGV_CongTac.Rows[e.RowIndex].Selected = true;
                foreach (DataGridViewCell cell in DGV_CongTac.Rows[e.RowIndex].Cells)
                {
                    cell.Selected = true;
                }
            }
        }

        private void DgvCD_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvCD.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn đầu tiên
                DataGridViewRow selectedRow = DgvCD.SelectedRows[0];

                // Lấy giá trị từ cột "TenChucDanh" của dòng được chọn
                string Id = selectedRow.Cells["Id"].Value.ToString();
                string tenChucDanh = selectedRow.Cells["TenChucDanh"].Value.ToString();

                // Gán giá trị vào TextBox
                txtTenChucDanh.Text = tenChucDanh;
                txtMaChucDanh.Text = Id;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int chucDanhId = int.Parse(txtMaChucDanh.Text);
            int status = 0;
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.XoaChucDanh(chucDanhId, status);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

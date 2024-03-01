
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
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void tabChucDanh_Click(object sender, EventArgs e)
        {
            ChucDanhDAL GoiChucDanh = new ChucDanhDAL();
            List<DTO.ChucDanhDTO> DsChucDanh = GoiChucDanh.LayChucDanh();
            DgvCD.DataSource = DsChucDanh;
            DgvCD.AutoGenerateColumns = true;
        }

        private void btnThemCD_Click(object sender, EventArgs e)
        {
            ThemCD cD = new ThemCD();
            cD.ShowDialog();
        }

        private void btnSuaCD_Click(object sender, EventArgs e)
        {
            int chucDanhId = int.Parse(cboMaChucDanh.Text);
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.SuaChucDanh(chucDanhId, txtTenChucDanh.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CongTacDAL GoiCongTac = new CongTacDAL();
            List<DTO.CongTacDTO> DsCongTac = GoiCongTac.LayCongTac();
            DGV_CongTac.DataSource = DsCongTac;
            DGV_CongTac.AutoGenerateColumns = true;
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            CongTacDAL GoiCongTac = new CongTacDAL();
            List<DTO.CongTacDTO> DsCongTac = GoiCongTac.LayCongTac();
            DGV_CongTac.DataSource = DsCongTac;
            DGV_CongTac.AutoGenerateColumns = true;

        }

        private void DgvCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ChucDanhDAL GoiChucDanh = new ChucDanhDAL();
            List<DTO.ChucDanhDTO> DsChucDanh = GoiChucDanh.LayChucDanh();
            DgvCD.DataSource = DsChucDanh;
            DgvCD.AutoGenerateColumns = true;
        }

        private void cboMaChucDanh_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                cboMaChucDanh.Text=Id;
            }
        }

        private void DgvCD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DgvCD.Rows[e.RowIndex].Selected = true;
                foreach (DataGridViewCell cell in DgvCD.Rows[e.RowIndex].Cells)
                {
                    cell.Selected = true;
                }
            }
        }

        private void btnXoaCD_Click(object sender, EventArgs e)
        {
            int chucDanhId = int.Parse(cboMaChucDanh.Text);
            int status = 0;
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.XoaChucDanh(chucDanhId,status);
        }

        private void tabCongTac_Click(object sender, EventArgs e)
        {
            CongTacDAL GoiCongTac = new CongTacDAL();
            List<DTO.CongTacDTO> DsCongTac = GoiCongTac.LayCongTac();
            DGV_CongTac.DataSource = DsCongTac;
            DGV_CongTac.AutoGenerateColumns = true;
        }

        private void btnSuaCT_Click(object sender, EventArgs e)
        {
            int congtacID = int.Parse(cboMaCongTac.Text);
            CongTacDAL congTacDAL = new CongTacDAL();
            congTacDAL.SuaCongTac(congtacID, txtTenCongTac.Text);
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            int congtacID = int.Parse(cboMaCongTac.Text);
            int Status = 0; // Giả sử bạn muốn đặt status = 0 khi xóa công tác
            CongTacDAL congTacDAL = new CongTacDAL();
            congTacDAL.XoaCongTac(congtacID,Status);
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

        private void DGV_CongTac_SelectionChanged(object sender, EventArgs e)
        {
            if(DGV_CongTac.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn đầu tiên
                DataGridViewRow selectedRow = DGV_CongTac.SelectedRows[0];

                // Lấy giá trị từ cột "TenChucDanh" của dòng được chọn
                string MaCongTac = selectedRow.Cells["MaCongTac"].Value.ToString();
                string tenChucDanh = selectedRow.Cells["TenCongTac"].Value.ToString();

                // Gán giá trị vào TextBox
                txtTenCongTac.Text = tenChucDanh;
                cboMaCongTac.Text = MaCongTac;
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            ThemCT themCT = new ThemCT();
            themCT.ShowDialog();
        }

        private void btnSuaCT_Click_1(object sender, EventArgs e)
        {
            int congtacID = int.Parse(cboMaCongTac.Text);
            CongTacDAL congTacDAL = new CongTacDAL();
            congTacDAL.SuaCongTac(congtacID, txtTenCongTac.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int congtacID = int.Parse(cboMaCongTac.Text);
            int Status = 0; // Giả sử bạn muốn đặt status = 0 khi xóa công tác
            CongTacDAL congTacDAL = new CongTacDAL();
            congTacDAL.XoaCongTac(congtacID, Status);
        }

        private void btnMoi_Click_1(object sender, EventArgs e)
        {
            CongTacDAL GoiCongTac = new CongTacDAL();
            List<DTO.CongTacDTO> DsCongTac = GoiCongTac.LayCongTac();
            DGV_CongTac.DataSource = DsCongTac;
            DGV_CongTac.AutoGenerateColumns = true;
        }

        private void btnThemCD_Click_1(object sender, EventArgs e)
        {
            ThemCD cD = new ThemCD();
            cD.ShowDialog();
        }

        private void btnSuaCD_Click_1(object sender, EventArgs e)
        {
            int chucDanhId = int.Parse(cboMaChucDanh.Text);
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.SuaChucDanh(chucDanhId, txtTenChucDanh.Text);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaCD_Click_1(object sender, EventArgs e)
        {
            int chucDanhId = int.Parse(cboMaChucDanh.Text);
            int status = 0;
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.XoaChucDanh(chucDanhId, status);
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            ChucDanhDAL GoiChucDanh = new ChucDanhDAL();
            List<DTO.ChucDanhDTO> DsChucDanh = GoiChucDanh.LayChucDanh();
            DgvCD.DataSource = DsChucDanh;
            DgvCD.AutoGenerateColumns = true;
        }
    }
}

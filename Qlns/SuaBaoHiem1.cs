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
    public partial class SuaBaoHiem1 : Form
    {
        private string Id;
        private string TienBaoHiem;
        private string NgayCap;
        private string NoiCap;
        private string GhiChu;
        private string IdNhanVien;
        public SuaBaoHiem1(string Id, string TienBaoHiem, string NgayCap, string NoiCap, string GhiChu, string IdNhanVien)
        {
            InitializeComponent();
            // Lưu dữ liệu được truyền vào các biến
            this.Id = Id;
            this.TienBaoHiem = TienBaoHiem;
            this.NgayCap = NgayCap;
            this.NoiCap = NoiCap;
            this.GhiChu = GhiChu;
            this.IdNhanVien = IdNhanVien;

            // Cập nhật giao diện với dữ liệu được truyền vào
            txtTienBaoHiem.Text = TienBaoHiem;
            DateNgayCap.Text = NgayCap;
            txtNoiCap.Text = NoiCap;
            txtGhiChu.Text = GhiChu;

            // Chọn mục tương ứng trong cboMaBaoHiem và cboMaNhanVien
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Chuyển đổi giá trị ngày từ DateTimePicker sang chuỗi đúng định dạng
            string ngayCap = DateNgayCap.Value.ToString("yyyyMMdd");
            int IdBaoHiem = int.Parse(cboMaBaoHiem.Text);
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            // Lấy các giá trị từ các điều khiển trên giao diện và truyền vào phương thức ThemBaoHiem
            BaoHiemDAL baoHiemDAL = new BaoHiemDAL();
            baoHiemDAL.SuaBaoHiem(IdBaoHiem, cboMaNhanVien.Text, ngayCap, Convert.ToInt32(txtGhiChu.Text), Convert.ToInt32(txtTienBaoHiem.Text), txtNoiCap.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

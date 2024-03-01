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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void Dd_Click(object sender, EventArgs e)
        {

        }

        private void txtDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtDangNhap.Text;
            string MatKhau =txtMatKhau.Text;
            string Role=cbRole.Text;
            DangNhapDAL dangNhapDAL = new DangNhapDAL();
            string TenTaiKhoan=dangNhapDAL.DangNhap(TaiKhoan, MatKhau,Role);
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Restauran_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restauran.Visible = false;
            Max.Visible = true;
        }

        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restauran.Visible = true;
            Max.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
}

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
    }
}

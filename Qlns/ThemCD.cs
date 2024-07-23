
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
    public partial class ThemCD : Form
    {
        public ThemCD()
        {
            InitializeComponent();
        }
        private void ThemChucDanh()
        {


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.ThemChucDanh(txtTenChucDanh.Text);
            this.Close();
        }

        private void txtTenChucDanh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

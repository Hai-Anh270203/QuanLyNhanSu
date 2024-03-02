
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
        private void ThemChucD_Click(object sender, EventArgs e)
        {
            ChucDanhDAL chucDanhDAL = new ChucDanhDAL();
            chucDanhDAL.ThemChucDanh(txtTenChucDanh.Text);
           
        }

        public void TenChucDanh_TextChanged(object sender, EventArgs e)
        {
          
        }
      
        private void ThemCD_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

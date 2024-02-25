using Qlns.BUS;
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
            string TenChucDanh = txtTenChucDanh.Text;
            ChucDanhBUS chucDanhBUS = new ChucDanhBUS();
            chucDanhBUS.ThemCD(TenChucDanh);
        }

        public void TenChucDanh_TextChanged(object sender, EventArgs e)
        {
          
        }
      
        private void ThemCD_Load(object sender, EventArgs e)
        {

        }
    }
}

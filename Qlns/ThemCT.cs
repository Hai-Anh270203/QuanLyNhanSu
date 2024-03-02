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
    public partial class ThemCT : Form
    {
        public ThemCT()
        {
            InitializeComponent();
        }

        private void ThemCongTac_Click(object sender, EventArgs e)
        {
            CongTacDAL congTacDAL = new CongTacDAL();
            congTacDAL.ThemCongTac(txtTenCongTac.Text);
        }
    }
}

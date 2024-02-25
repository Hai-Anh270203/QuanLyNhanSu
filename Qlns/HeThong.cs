using Qlns.BUS;
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
    }
}

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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_BackgroundImageChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có hình ảnh nền hay không
            if (this.BackgroundImage != null)
            {
                // Thiết lập kích thước mới cho hình ảnh nền
                int newWidth = 500;
                int newHeight = 300;
                this.BackgroundImageLayout = ImageLayout.Stretch; // Hoặc một giá trị khác tùy thuộc vào yêu cầu của bạn

                this.Invalidate();
            }
        }
    }
}

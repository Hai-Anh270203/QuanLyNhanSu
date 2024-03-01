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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            DangNhap dnAdmin = new DangNhap(); // Tạo một thể hiện mới của form DNAdmin
            dnAdmin.Show(); // Hiển thị form DNAdmin mà không chặn form hiện tại
            this.Hide(); // Ẩn form hiện tại thay vì đóng nó
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DNnhanvien dnNV = new DNnhanvien(); // Tạo một thể hiện mới của form DNAdmin
            dnNV.Show(); // Hiển thị form DNAdmin mà không chặn form hiện tại
            this.Hide(); // Ẩn form hiện tại thay vì đóng nó
        }
    }
}

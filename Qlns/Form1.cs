using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Qlns.DAL;


namespace Qlns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Close_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restauran.Visible = true;
            Max.Visible = false;
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

        private void button1_Resize(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Tabheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tabheader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void OpenFormInPanel(object ChildForm)
        {
            // Kiểm tra nếu Panel chứa các điều khiển (controls) đã có
            if (this.Container.Controls.Count > 0)
                this.Container.Controls.RemoveAt(0);

            // Ép kiểu đối tượng con thành kiểu Form
            Form childForm = ChildForm as Form;

            // Đặt đối tượng con không phải là TopLevel để có thể chứa nó trong Panel
            childForm.TopLevel = false;

            // Đặt thuộc tính Dock của đối tượng con để điền vào toàn bộ kích thước của Panel
            childForm.Dock = DockStyle.Fill;

            // Thêm đối tượng con vào Panel
            this.Container.Controls.Add(childForm);

            // Gắn Tag cho Panel để lưu trữ thông tin về đối tượng con
            this.Container.Tag = childForm;

            // Hiển thị đối tượng con
            childForm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Home());
        }

        private void MoveControlsLeft()
        {
            // Di chuyển các controls về bên trái (ví dụ: Accout_img)
            Accout_img.Location = new Point(Accout_img.Location.X - 19, Accout_img.Location.Y);

            // Ẩn các button khác nếu cần
            // ...
        }

        private void MoveControlsRight()
        {
            // Di chuyển các controls về bên phải (ví dụ: Accout_img)
            Accout_img.Location = new Point(Accout_img.Location.X + 19, Accout_img.Location.Y);

            // Hiển thị các button khác nếu cần
            // ...
        }
        private void Bar_Click(object sender, EventArgs e)
        {
            if (Vertical.Width == 275)
            {
                Vertical.Width = 60;
                MoveControlsLeft(); // Di chuyển các controls về bên trái
                Admin.Visible = false;
                btnHome.Text = "";
                btnnhanvien.Text = "";
                btnchamcong.Text = "";
                btnbophan.Text = "";
                btnbangluong.Text = "";
                btnBaocao.Text = "";
                btnTracuu.Text= "";
                btnHeThong.Text = "";
            }
            else
            {
                Vertical.Width = 275;
                MoveControlsRight(); // Di chuyển các controls về bên phải
                Admin.Visible = true;
                btnHome.Text = "Trang chủ";
                btnnhanvien.Text = "Nhân viên";
                btnchamcong.Text = "Chấm công";
                btnbophan.Text = "Bộ phận";
                btnbangluong.Text = "Bảng lương";
                btnBaocao.Text = "Báo cáo thống kê";
                btnTracuu.Text = "Tra cứu thông tin";
                btnHeThong.Text = "Hệ thống";

            }
        }
       /* private void loadChucDanh()
        {
            ChucDanhDAL GoiChucDanh= new ChucDanhDAL();
            List<DTO.ChucDanhDTO> DsChucDanh = GoiChucDanh.LayChucDanh();
            DGV.DataSource= DsChucDanh;
            DGV.AutoGenerateColumns = true;

        }*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*loadChucDanh();*/
        }

        private void Logohome_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu Panel chứa các điều khiển đã có
            if (this.Container.Controls.Count > 0)
            {
                // Đóng form con hiện tại
                Form currentChildForm = this.Container.Controls[0] as Form;
                currentChildForm.Close();

            }

            // Tạo sự kiện đặc biệt để trở về trạng thái ban đầu (ví dụ: Form1)
            // Bạn có thể thay đổi thành form khác nếu cần

        }
        private void ThemChucDanh()
        {
           
                   
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new NhanVien());
        }

        private void Accout_img_Click(object sender, EventArgs e)
        {

        }

        private void Accout_img_MouseLeave(object sender, EventArgs e)
        {
            if (Accout_img.Tag != null)
            {
                // Khôi phục kích thước ban đầu khi chuột rời đi
                Accout_img.Size = (Size)Accout_img.Tag;
            }
        }


        private void Accout_img_MouseHover_1(object sender, EventArgs e)
        {
            // Lưu kích thước ban đầu
            Accout_img.Tag = Accout_img.Size;

            // Phóng to ảnh khi chuột di vào
            Accout_img.Width = (int)(Accout_img.Width * 1.1);
            Accout_img.Height = (int)(Accout_img.Height * 1.1);
        }

        private void Vertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {

        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {

        }

        private void btnbangluong_Click(object sender, EventArgs e)
        {

        }

        private void btnchamcong_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ChamCong());
        }

        private void btnbophan_Click(object sender, EventArgs e)
        {
            
        }

        private void Container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

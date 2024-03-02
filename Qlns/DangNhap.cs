using Qlns.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        private void Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTenDN.Text;
            string MatKhau = txtMk.Text;
            string Role = cbRole.Text;

            if (string.IsNullOrEmpty(TaiKhoan) || string.IsNullOrEmpty(MatKhau) || string.IsNullOrEmpty(Role))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập.");
                return;
            }

            DangNhapDAL dangNhapDAL = new DangNhapDAL();
            string userRole = dangNhapDAL.DangNhap(TaiKhoan, MatKhau, Role);
            try
            {

                // Chuyển hướng người dùng dựa trên vai trò của họ
                if(userRole == "Quản trị viên")
                {
                    // Chuyển đến form quản trị
                    Form1 adminForm = new Form1();
                    adminForm.Show();
                    this.Hide();
                } else if( userRole == "Nhân viên")
                {
                    // Chuyển đến form nhân viên
                    demoNgoc employeeForm = new demoNgoc();
                    employeeForm.Show();
                    this.Hide();
                }else
                        MessageBox.Show("Vai trò không hợp lệ.");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập không thành công: " + ex.Message);
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM Role";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cbRole.DataSource = dataTable;
                    cbRole.DisplayMember = "Role";
                    cbRole.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

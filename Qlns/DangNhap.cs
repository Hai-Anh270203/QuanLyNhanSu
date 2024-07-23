using Qlns.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Qlns
{
    public partial class DangNhap : Form
    {
        public static string MaNhanVien;
        public DangNhap()
        {
            InitializeComponent();
        }
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        private void btnDN_Click(object sender, EventArgs e)
        {
            MaNhanVien = txtTenDN.Text;
            DangNhapDAL ac = new DangNhapDAL();
            string tk = txtTenDN.Text;
            string mk = txtMk.Text;
            string selectedRole = cbRole.Text;

            // Sử dụng tham số trong câu lệnh SQL để tránh SQL Injection
            string sql = "SELECT Users.Id, Role_User.IdRole, NhanVien.MaNhanVien, Users.MatKhau FROM Users " +
                         "JOIN Role_User ON Users.Id = Role_User.IdUser " +
                         "JOIN NhanVien On NhanVien.IdUser = Users.Id " +
                         "WHERE MaNhanVien = N'" + tk + "'  AND NhanVien.Status = '1'";

            using (connection = kn.OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@MaNhanVien", tk);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Đọc mật khẩu từ cơ sở dữ liệu
                        string hashedPasswordFromDB = reader["MatKhau"].ToString();
                        Provide.pass maHoaMK = new Provide.pass();
                        string hashedInput = maHoaMK.HashPassword(mk);
                        // So sánh mật khẩu đã được mã hóa từ cơ sở dữ liệu với mật khẩu đã được mã hóa từ người dùng
                        if (hashedInput == hashedPasswordFromDB)
                        {
                            List<string> userRoles = ac.GetUserRoles(tk, hashedInput);

                            if (userRoles.Contains(selectedRole))
                            {
                                if (selectedRole == "Quản trị viên")
                                {
                                    DialogResult dl = MessageBox.Show("Chào mừng Admin !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (dl == DialogResult.OK)
                                    {
                                        GiaoDien nv = new GiaoDien();
                                        nv.Show();
                                        this.Hide();
                                    }
                                }
                                else if (selectedRole == "Nhân viên")
                                {
                                    DialogResult dl = MessageBox.Show("Chào mừng user !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (dl == DialogResult.OK)
                                    {
                                        GiaodienNV main = new GiaodienNV();
                                        main.Show();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vai trò không hợp lệ cho người dùng đã chọn.");
                                }
                            }
                            else
                            {
                                DialogResult dl = MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                if (dl == DialogResult.OK)
                                {
                                    txtMk.Clear();
                                    txtMk.Focus();
                                }
                            }
                        }
                        else
                        {
                            // Thông báo mật khẩu không đúng
                        }
                    }
                    else
                    {
                        // Thông báo không tìm thấy người dùng
                    }
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cbRole.DataSource = dt;
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

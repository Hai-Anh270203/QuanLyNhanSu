using Qlns.ConnectDB;
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
    public partial class Tracuu1 : Form
    {
        public Tracuu1()
        {
            InitializeComponent();
        }
        private KetNoi ketNoi = new KetNoi();
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void Tracuu1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CongTac where Congtac.Status = '1' ", connection))
                {
                    DataTable ct = new DataTable();
                    adapter.Fill(ct);
                    comboBox2.DataSource = ct;
                    comboBox2.DisplayMember = "TenCongTac";
                    comboBox2.ValueMember = "CongTac.Id";
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM ChucDanh where Chucdanh.Status = '1'", connection))
                {
                    DataTable cd = new DataTable();
                    adapter.Fill(cd);

                    comboBox1.DataSource = cd;
                    comboBox1.DisplayMember = "TenChucDanh";
                    comboBox1.ValueMember = "ChucDanh.Id";
                }

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                string sql = @"SELECT NhanVien.MaNhanVien, Users.HoTen, Users.NgaySinh, Users.Email, Users.CMND, CongTac.TenCongTac, ChucDanh.TenChucDanh
                  FROM     Users INNER JOIN
                  NhanVien ON Users.Id = NhanVien.IdUser INNER JOIN
                  CongTac ON NhanVien.IdCongTac = CongTac.Id INNER JOIN
                  ChucDanh ON NhanVien.IdChucDanh = ChucDanh.Id";
                string st = " and NhanVien.Status='1'";
                string dk = "1=1";

                if (textBox1.Text.Trim() != "")
                {
                    dk = dk + string.Format("and HoTen like '%{0}%'", textBox1.Text);
                }

                if (textBox2.Text.Trim() != "")
                {
                    dk = dk + string.Format("and MaNhanVien like '%{0}%'", textBox2.Text);
                }

                if (textBox4.Text.Trim() != "")
                {
                    dk = dk + string.Format("and CMND='{0}'", textBox4.Text);
                }

                if (comboBox1.SelectedIndex >= 0)
                {
                    dk = dk + string.Format("and ChucDanh.Id='{0}'", comboBox1.SelectedValue);
                }
                if (comboBox2.SelectedIndex >= 0)
                {
                    dk = dk + string.Format("and CongTac.Id='{0}'", comboBox2.SelectedValue);
                }

                sql = sql + " where " + dk + st ;

                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = dt;
                }




            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();

            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

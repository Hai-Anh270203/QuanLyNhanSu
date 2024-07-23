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
    public partial class DSKT1 : Form
    {
        private KetNoi ketNoi = new KetNoi();
        public string TextBox6Data { get; set; }
        private ChamCong1 chamCongWindow;
        public int idNhanVien { get; set; }
        public int idKhenThuong { get; set; }
        private string selectedTienKT;
        public DSKT1(ChamCong1 chamCongWindow)
        {
            InitializeComponent();
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Load += new System.EventHandler(this.DSKT1_Load);
            this.chamCongWindow = chamCongWindow;
        }

        private void DSKT1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Tien, KhenThuong FROM KhenThuong", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }

            textBox3.Text = TextBox6Data;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string SoTien = Convert.ToString(selectedRow.Cells["TienKT"].Value);
                textBox1.Text = SoTien;


                using (SqlConnection connection = ketNoi.OpenConnection())
                {

                    using (SqlCommand command = new SqlCommand("SELECT Id FROM KhenThuong WHERE Tien = @Tien", connection))
                    {
                        command.Parameters.AddWithValue("@Tien", SoTien);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            idKhenThuong = Convert.ToInt32(result);
                        }
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int soLan;
            decimal soTien, tongTien;

            if (decimal.TryParse(textBox1.Text, out soTien) && int.TryParse(textBox2.Text, out soLan))
            {
                tongTien = soTien * soLan;
                textBox4.Text = tongTien.ToString();
            }
            else
            {
                textBox4.Text = "Dữ liệu không hợp lệ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlCommand cmd = new SqlCommand("INSERT INTO KhenThuong_NhanVien (IdKhenThuong, IdNhanVien) VALUES (@idKhenThuong, @idNhanVien)", connection))
                {
                    cmd.Parameters.AddWithValue("@idKhenThuong", idKhenThuong);
                    cmd.Parameters.AddWithValue("@idNhanVien", idNhanVien);

                    for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            decimal tiensanco = 0, tiencongthem = 0;
            if (!decimal.TryParse(textBox3.Text, out tiensanco))
            {
                tiensanco = 0;
            }
            if (!decimal.TryParse(textBox4.Text, out tiencongthem))
            {
                tiencongthem = 0;
            }
            selectedTienKT = (tiensanco + tiencongthem).ToString();
            chamCongWindow.textBox6.Text = this.selectedTienKT;


            // Đóng cửa sổ DSKT
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlCommand cmd = new SqlCommand("DELETE FROM KhenThuong_NhanVien WHERE IdKhenThuong = @idKhenThuong AND IdNhanVien = @idNhanVien", connection))
                {
                    cmd.Parameters.AddWithValue("@idKhenThuong", idKhenThuong);
                    cmd.Parameters.AddWithValue("@idNhanVien", idNhanVien);

                    for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            decimal tiensanco = 0, tientrubot = 0;
            if (!decimal.TryParse(textBox3.Text, out tiensanco))
            {
                tiensanco = 0;
            }
            if (!decimal.TryParse(textBox4.Text, out tientrubot))
            {
                tientrubot = 0;
            }
            selectedTienKT = (tiensanco - tientrubot).ToString();
            chamCongWindow.textBox6.Text = this.selectedTienKT;


            // Đóng cửa sổ DSKT
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}

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
    public partial class DSKL1 : Form
    {
        private KetNoi ketNoi = new KetNoi();
        public string TextBox7Data { get; set; }
        private ChamCong1 chamCongWindow;
        public int idNhanVien { get; set; }
        public int idKiLuat { get; set; }
        private string selectedTienKL;
        public DSKL1(ChamCong1 chamCongWindow)
        {
            InitializeComponent();
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Load += new System.EventHandler(this.DSKL1_Load);
            this.chamCongWindow = chamCongWindow;
        }
       
        private void DGV_CongTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DSKL1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Tien, KiLuat FROM KiLuat", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            textBox4.Text = TextBox7Data;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string SoTien = Convert.ToString(selectedRow.Cells["TienKL"].Value);
                textBox1.Text = SoTien;


                using (SqlConnection connection = ketNoi.OpenConnection())
                {

                    using (SqlCommand command = new SqlCommand("SELECT Id FROM KiLuat WHERE Tien = @Tien", connection))
                    {
                        command.Parameters.AddWithValue("@Tien", SoTien);
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            idKiLuat = Convert.ToInt32(result);
                        }
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int soLan;
            decimal soTien, tongTien;

            if (decimal.TryParse(textBox1.Text, out soTien) && int.TryParse(textBox2.Text, out soLan))
            {
                tongTien = soTien * soLan;
                textBox3.Text = tongTien.ToString();
            }
            else
            {
                textBox3.Text = "Dữ liệu không hợp lệ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlCommand cmd = new SqlCommand("INSERT INTO KiLuat_NhanVien (IdKiLuat, IdNhanVien) VALUES (@idKiLuat, @idNhanVien)", connection))
                {
                    cmd.Parameters.AddWithValue("@idKiLuat", idKiLuat);
                    cmd.Parameters.AddWithValue("@idNhanVien", idNhanVien);

                    for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            decimal tiensanco = 0, tiencongthem = 0;
            if (!decimal.TryParse(textBox4.Text, out tiensanco))
            {
                tiensanco = 0;
            }
            if (!decimal.TryParse(textBox3.Text, out tiencongthem))
            {
                tiencongthem = 0;
            }
            selectedTienKL = (tiensanco + tiencongthem).ToString();
            chamCongWindow.textBox7.Text = this.selectedTienKL;


            // Đóng cửa sổ DSKT
            this.Close();
        }

        //Nút trừ bớt
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlCommand cmd = new SqlCommand("DELETE FROM KiLuat_NhanVien WHERE IdKiLuat = @idKiLuat AND IdNhanVien = @idNhanVien", connection))
                {
                    cmd.Parameters.AddWithValue("@idKiLuat", idKiLuat);
                    cmd.Parameters.AddWithValue("@idNhanVien", idNhanVien);

                    for (int i = 0; i < Convert.ToInt32(textBox2.Text); i++)
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            decimal tiensanco = 0, tientrubot = 0;
            if (!decimal.TryParse(textBox4.Text, out tiensanco))
            {
                tiensanco = 0;
            }
            if (!decimal.TryParse(textBox3.Text, out tientrubot))
            {
                tientrubot = 0;
            }
            selectedTienKL = (tiensanco - tientrubot).ToString();
            chamCongWindow.textBox7.Text = this.selectedTienKL;


            // Đóng cửa sổ DSKT
            this.Close();
        }
    }
}

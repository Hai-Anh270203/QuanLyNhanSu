using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Qlns
{
    public partial class DSKT : Form
    {
        // Thêm thuộc tính để lưu trữ dữ liệu từ cửa sổ ChamCong
        public string TextBox6Data { get; set; }
        private ChamCong chamCongWindow;
        public DSKT(ChamCong chamCongWindow)
        {
            InitializeComponent();
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Load += new System.EventHandler(this.DSKT_Load);
            this.chamCongWindow = chamCongWindow;
        }

        private void DSKT_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Id, Tien, KhenThuong FROM KhenThuong", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                connection.Close();
            }

            // Cập nhật textBox3 với dữ liệu từ cửa sổ ChamCong
            textBox3.Text = TextBox6Data;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string MaKhenThuong = Convert.ToString(selectedRow.Cells["MaKhenThuong"].Value);
                string SoTien = Convert.ToString(selectedRow.Cells["TienKT"].Value);
                string LiDo = Convert.ToString(selectedRow.Cells["LiDo"].Value);
                textBox1.Text = SoTien;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int soLan;
            decimal soTien, tongTien;

            // Kiểm tra xem textBox1 và textBox2 có phải là số không
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
            decimal soTienCoSan = decimal.Parse(textBox3.Text);
            decimal tongTien = decimal.Parse(textBox4.Text);
            soTienCoSan += tongTien;
            textBox3.Text = soTienCoSan.ToString();
            // Giả sử chamCongForm là thể hiện của cửa sổ ChamCong
            chamCongWindow.TextBox6Data = soTienCoSan.ToString();
            this.Close();
        }

        // Thêm phương thức xử lý sự kiện Click cho nút "Trừ bớt"
        private void button2_Click(object sender, EventArgs e)
        {
            decimal soTienCoSan = decimal.Parse(textBox3.Text);
            decimal tongTien = decimal.Parse(textBox4.Text);
            soTienCoSan -= tongTien;
            textBox3.Text = soTienCoSan.ToString();
            // Giả sử chamCongForm là thể hiện của cửa sổ ChamCong
            chamCongWindow.TextBox6Data = soTienCoSan.ToString();
        }

       
    }
}

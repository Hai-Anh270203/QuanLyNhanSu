using System;
using System.Collections;
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
    public partial class ChamCong : Form
    {
        // Thêm thuộc tính để lưu trữ dữ liệu từ textBox6
        public string TextBox6Data { get; set; }

        public ChamCong()
        {
            InitializeComponent();
            
            // Thêm sự kiện TextChanged cho textBox6
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
        }
        ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();

        private void buttonnv_Click(object sender, EventArgs e)
        {
            // Truyền tham chiếu của cửa sổ ChamCong vào cửa sổ DSNV
            DSNV ds = new DSNV(this);
            ds.Show();
        }

        private void buttonkt_Click(object sender, EventArgs e)
        {
            DSKT dskt = new DSKT(this);
            // Cập nhật TextBox6Data trên cửa sổ KhenThuong
            dskt.TextBox6Data = this.TextBox6Data;
            dskt.Show();
        }

        private void buttonkl_Click(object sender, EventArgs e)
        {
            DSKL dSKL = new DSKL();
            dSKL.Show();
        }

        // Thêm phương thức xử lý sự kiện TextChanged cho textBox6
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox6Data = textBox6.Text;
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();
            try
            {
                using (SqlConnection ketnoi = Kn.OpenConnection())
                {
                    // Truy vấn dữ liệu từ bảng KhenThuong và hiển thị trong dataGridView2
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KhenThuong", ketnoi))
                    {
                        DataTable dtKhenThuong = new DataTable();
                        adapter.Fill(dtKhenThuong);
                        dataGridView2.DataSource = dtKhenThuong;
                    }

                    // Truy vấn dữ liệu từ bảng KiLuat và hiển thị trong dataGridView3
                    using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KiLuat", ketnoi))
                    {
                        DataTable dtKiLuat = new DataTable();
                        adapter.Fill(dtKiLuat);
                        dataGridView3.DataSource = dtKiLuat;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO KhenThuong (KhenThuong, Tien) VALUES (@LiDo, @Tien )", connection))
                {
                    
                    command.Parameters.AddWithValue("@Tien", textBox12.Text);
                    command.Parameters.AddWithValue("@LiDo", textBox13.Text);

                    command.ExecuteNonQuery();
                }
            }
            // Cập nhật dataGridView sau khi thêm dữ liệu mới
            ChamCong_Load(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO KiLuat (KiLuat, Tien) VALUES (@LiDo, @Tien )", connection))
                {

                    command.Parameters.AddWithValue("@Tien", textBox15.Text);
                    command.Parameters.AddWithValue("@LiDo", textBox14.Text);

                    command.ExecuteNonQuery();
                }
            }
            // Cập nhật dataGridView sau khi thêm dữ liệu mới
            ChamCong_Load(sender, e);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];

                string MaKhenThuong = Convert.ToString(selectedRow.Cells["MaKhenThuong"].Value);
                string LiDo = Convert.ToString(selectedRow.Cells["LiDoKhenThuong"].Value);
                string Tien = Convert.ToString(selectedRow.Cells["TienKhenThuong"].Value);


                textBox5.Text = MaKhenThuong;
                textBox12.Text = Tien;
                textBox13.Text = LiDo;



            }
        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView3.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView3.Rows[selectedrowindex];

                string MaKiLuat = Convert.ToString(selectedRow.Cells["MaKiLuat"].Value);
                string LiDo = Convert.ToString(selectedRow.Cells["LiDoKiLuat"].Value);
                string Tien = Convert.ToString(selectedRow.Cells["TienKiLuat"].Value);


                textBox16.Text = MaKiLuat;
                textBox15.Text = Tien;
                textBox14.Text = LiDo;



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM KhenThuong WHERE Id = @MaKhenThuong", connection))
                {
                    command.Parameters.AddWithValue("@MaKhenThuong", textBox5.Text);
                    command.ExecuteNonQuery();
                }
            }
            ChamCong_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM KiLuat WHERE Id = @MaKiLuat", connection))
                {
                    command.Parameters.AddWithValue("@MaKiLuat", textBox16.Text);
                    command.ExecuteNonQuery();
                }
            }
            ChamCong_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE KhenThuong SET Tien = @Tien, KhenThuong = @LiDo WHERE Id = @MaKhenThuong", connection))
                {
                    command.Parameters.AddWithValue("@MaKhenThuong", textBox5.Text);
                    command.Parameters.AddWithValue("@Tien", textBox12.Text);
                    command.Parameters.AddWithValue("@LiDo", textBox13.Text);
                    command.ExecuteNonQuery();
                }
            }
            // Cập nhật dataGridView sau khi sửa dữ liệu
            ChamCong_Load(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE KiLuat SET Tien = @Tien, KiLuat = @LiDo WHERE Id = @MaKiLuat", connection))
                {
                    command.Parameters.AddWithValue("@MaKiLuat", textBox16.Text);
                    command.Parameters.AddWithValue("@Tien", textBox15.Text);
                    command.Parameters.AddWithValue("@LiDo", textBox14.Text);
                    command.ExecuteNonQuery();
                }
            }
            // Cập nhật dataGridView sau khi sửa dữ liệu
            ChamCong_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

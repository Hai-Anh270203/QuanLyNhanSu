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
    public partial class ChamCong : Form
    {
        private KetNoi ketNoi = new KetNoi();
        // Thêm thuộc tính để lưu trữ dữ liệu từ textBox6 và 7 
        public string TextBox6Data { get; set; }
        public string TextBox7Data { get; set; }

        public ChamCong()
        {
            InitializeComponent();
            // Thêm sự kiện Lưu thay đổi cho textBox6
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);

        }

        //Mở cửa sổ Danh sách nhân viên
        private void buttonnv_Click(object sender, EventArgs e)
        {
            // Truyền tham chiếu của cửa sổ ChamCong vào cửa sổ DSNV
            DSNV ds = new DSNV(this);
            ds.Show();
        }

        //Mở cửa sổ khen thưởng
        private void buttonkt_Click(object sender, EventArgs e)
        {
            DSKT dskt = new DSKT(this);
            // Cập nhật TextBox6Data trên cửa sổ KhenThuong
            dskt.TextBox6Data = this.TextBox6Data;
            dskt.Show();

            
            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                
                using (SqlCommand command = new SqlCommand("SELECT Id FROM NhanVien WHERE MaNhanVien = @MaNhanVien", connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", textBox1.Text);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        dskt.idNhanVien = Convert.ToInt32(result);
                    }
                }
            }
        }

        //Mở cửa sổ kỉ luật
        private void buttonkl_Click(object sender, EventArgs e)
        {
            DSKL dskl = new DSKL(this);
            dskl.TextBox7Data = this.TextBox7Data;

            dskl.Show();

            
            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                
                using (SqlCommand command = new SqlCommand("SELECT Id FROM NhanVien WHERE MaNhanVien = @MaNhanVien", connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", textBox1.Text);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        dskl.idNhanVien = Convert.ToInt32(result);
                    }
                }
            }

        }

        // Thêm phương thức xử lý sự kiện TextChanged cho textBox7
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            TextBox7Data = textBox7.Text;
        }
        // Thêm phương thức xử lý sự kiện TextChanged cho textBox6
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            TextBox6Data = textBox6.Text;
        }

        //Load form 
        private void ChamCong_Load(object sender, EventArgs e)
        {
            
            
            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From KhenThuong", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From KiLuat", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView3.DataSource = dt;
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT LuongThang.MaNhanVien, Users.HoTen, LuongThang.TongLuong, LuongThang.Thang, LuongThang.Nam FROM LuongThang INNER JOIN NhanVien ON LuongThang.MaNhanVien = NhanVien.MaNhanVien INNER JOIN Users ON NhanVien.IdUser = Users.Id", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
        }


        //Hiển thị thông tin sau khi chọn tháng năm
        private void button9_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                
                using (SqlCommand command = new SqlCommand(@"
            SELECT 
                NV.Id,
                COUNT(DISTINCT NC.CongNgay) AS SoNgayCong,
                SUM(NC.GioLamThem) AS SoGioLamThem
            FROM 
                NhanVien NV
            LEFT JOIN 
                NgayCong NC ON NV.Id = NC.IdNhanVien
            WHERE 
                NV.MaNhanVien = @MaNhanVien AND
                MONTH(NC.CongNgay) = @Thang AND YEAR(NC.CongNgay) = @Nam
            GROUP BY 
                NV.Id", connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", textBox1.Text);
                    command.Parameters.AddWithValue("@Thang", comboBox1.SelectedItem); 
                    command.Parameters.AddWithValue("@Nam", textBox18.Text); 

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idNhanVien = reader.GetInt32(0);
                            int soNgayCong = reader.GetInt32(1);
                            int soGioLamThem = reader.GetInt32(2);

                           
                            textBox9.Text = soNgayCong.ToString();
                            textBox10.Text = soGioLamThem.ToString();
                        }
                    }
                }


            }



            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                
                using (SqlCommand command = new SqlCommand(@"
            SELECT 
                NV.Id,
                COUNT(DISTINCT NC.NgayNghi) AS SoNgayNghi
            FROM 
                NhanVien NV
            LEFT JOIN 
                NgayCong NC ON NV.Id = NC.IdNhanVien
            WHERE 
                NV.MaNhanVien = @MaNhanVien AND
                MONTH(NC.NgayNghi) = @Thang AND YEAR(NC.NgayNghi) = @Nam
            GROUP BY 
                NV.Id", connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", textBox1.Text);
                    command.Parameters.AddWithValue("@Thang", comboBox1.SelectedItem);
                    command.Parameters.AddWithValue("@Nam", textBox18.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idNhanVien = reader.GetInt32(0);
                            int soNgayNghi = reader.GetInt32(1);

                           
                            textBox8.Text = soNgayNghi.ToString();
                        }
                    }
                }


            }
        }

        //Tính lương và hiển thị
        private void buttontluong_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                

                using (SqlCommand command = new SqlCommand(@"
                    SELECT TL.LuongCong, TL.PhuCap, BH.TienBaoHiem
                    FROM NhanVien NV
                    JOIN TienLuong TL ON NV.IdTienLuong = TL.Id
                    LEFT JOIN BaoHiem BH ON NV.Id = BH.IdNhanVien
                    WHERE NV.MaNhanVien = @MaNhanVien", connection))
                {
                    command.Parameters.AddWithValue("@MaNhanVien", textBox1.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal luongCong = 0;
                            decimal phuCap = 0;
                            decimal baoHiem = 0;

                            int luongCongIndex = reader.GetOrdinal("LuongCong");
                            if (!reader.IsDBNull(luongCongIndex))
                            {
                                luongCong = Convert.ToDecimal(reader[luongCongIndex]);
                            }

                            int phuCapIndex = reader.GetOrdinal("PhuCap");
                            if (!reader.IsDBNull(phuCapIndex))
                            {
                                phuCap = Convert.ToDecimal(reader[phuCapIndex]);
                            }

                            int baoHiemIndex = reader.GetOrdinal("TienBaoHiem");
                            if (!reader.IsDBNull(baoHiemIndex))
                            {
                                baoHiem = Convert.ToDecimal(reader[baoHiemIndex]);
                            }

                            // Other variables you need for calculation
                            int soNgayCong = int.Parse(textBox9.Text);
                            decimal khenThuong = decimal.Parse(textBox6.Text);
                            decimal kiLuat = decimal.Parse(textBox7.Text);
                            decimal gioThem = decimal.Parse(textBox10.Text);
                            // Your existing code to calculate the salary
                            decimal salary = (luongCong * soNgayCong) + phuCap + khenThuong - kiLuat - baoHiem + gioThem*(luongCong/8) ;

                            // Display the result in textBox11
                            textBox11.Text = salary.ToString();
                        }
                    }
                }
            }
        }

        //Thêm vào data bảng LuongThang
        private void buttonthem_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                
                using (SqlCommand command = new SqlCommand("INSERT INTO LuongThang (MaNhanVien, TongLuong ,Thang,Nam) VALUES (@MaNV, @TL,@T,@N )", connection))
                {

                    command.Parameters.AddWithValue("@MaNV", textBox1.Text);
                    command.Parameters.AddWithValue("@TL", textBox11.Text);
                    command.Parameters.AddWithValue("@T", comboBox1.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@N", textBox18.Text);



                    command.ExecuteNonQuery();
                }
            }
            // Cập nhật dataGridView sau khi thêm dữ liệu mới
            ChamCong_Load(sender, e);
        }

        //Nút làm mới
        private void buttonlammoi_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();

            comboBox1.ResetText();
        }


        //Nút xuất excel 
        private void buttonex_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            excel.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = "";
                        }
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }









        /////////////////////////////////////////////////////TAB KHEN THƯỞNG VÀ KỈ LUẬT ///////////////////////////////////////////////////////////////////////////////////////


        //Thêm khen thưởng
        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = ketNoi.OpenConnection())
            {

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

        //Thêm kỉ luật 
        private void button8_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = ketNoi.OpenConnection())
            {

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

        //Chọn khen thưởng
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

        //Chọn kỉ luật
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

        //Xóa khen thưởng
        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlCommand command = new SqlCommand("DELETE FROM KhenThuong WHERE Id = @MaKhenThuong", connection))
                {
                    command.Parameters.AddWithValue("@MaKhenThuong", textBox5.Text);
                    command.ExecuteNonQuery();
                }
            }
            ChamCong_Load(sender, e);
        }

        //Xóa kỉ luật
        private void button6_Click(object sender, EventArgs e)
        {


            using (SqlConnection connection = ketNoi.OpenConnection())
            {

                using (SqlCommand command = new SqlCommand("DELETE FROM KiLuat WHERE Id = @MaKiLuat", connection))
                {
                    command.Parameters.AddWithValue("@MaKiLuat", textBox16.Text);
                    command.ExecuteNonQuery();
                }
            }
            ChamCong_Load(sender, e);
        }

        //Sửa khen thưởng
        private void button2_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = ketNoi.OpenConnection())
            {

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

        //Sửa kỉ luật
        private void button7_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = ketNoi.OpenConnection())
            {

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
    }
}

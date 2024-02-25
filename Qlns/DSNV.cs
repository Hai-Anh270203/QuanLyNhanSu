using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Qlns
{
    public partial class DSNV : Form
    {
        //public DSNV()
        //{
        //    InitializeComponent();
        //    this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
        //}
        private ChamCong chamCongWindow;
        private string selectedMaLuong , selectedLuong , selectedPhuCap , selectedTienKhenThuong , selectedTienKiLuat;

        public DSNV(ChamCong chamCongWindow)
        {
            InitializeComponent();
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            // Lưu trữ tham chiếu đến cửa sổ ChamCong
            this.chamCongWindow = chamCongWindow;
        }
        private void DSNV_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT NhanVien.MaNhanVien, NhanVien.IdCongTac, NhanVien.IdTienLuong, Users.HoTen, Users.CMND, CongTac.TenCongTac FROM   NhanVien INNER JOIN Users ON NhanVien.Id = Users.Id INNER JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                string MaNhanVien = Convert.ToString(selectedRow.Cells["MaNhanVien"].Value);
                string HoTen = Convert.ToString(selectedRow.Cells["HoTen"].Value);
                string MaPhong = Convert.ToString(selectedRow.Cells["MaPhong"].Value);
                string MaLuong = Convert.ToString(selectedRow.Cells["MaLuong"].Value);


                textBox1.Text = MaNhanVien;
                textBox2.Text = HoTen;
                 this.selectedMaLuong = MaLuong;

                // Kết nối đến cơ sở dữ liệu và truy vấn tên phòng
                string connectionString = @"Data Source=LAPTOP-QK5FMI7H\SQLEXPRESS01;Initial Catalog=QLNS3 (1);Persist Security Info=True;User ID=Nhi;Password=1;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT TenCongTac FROM CongTac WHERE Id = @MaPhong", connection))
                    {
                        command.Parameters.AddWithValue("@MaPhong", MaPhong);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            textBox4.Text = Convert.ToString(result);
                        }
                    }
                }
                using (SqlConnection connectionn = new SqlConnection(connectionString))
                {
                    connectionn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT Users.CMND FROM Users WHERE HoTen = @HoTen ", connectionn))
                    {
                        command.Parameters.AddWithValue("@HoTen", HoTen);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            textBox3.Text = Convert.ToString(result);
                        }
                    }
                }
                using (SqlConnection connectionn = new SqlConnection(connectionString))
                {
                    connectionn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT TienLuong.BacLuong, TienLuong.PhuCap FROM TienLuong INNER JOIN NhanVien ON TienLuong.Id = NhanVien.IdTienLuong WHERE MaNhanVien = @MaNhanVien ", connectionn))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.selectedLuong = Convert.ToString(reader["BacLuong"]);
                                this.selectedPhuCap = Convert.ToString(reader["PhuCap"]);
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand($"SELECT SUM(KhenThuong.Tien) as TienKhenThuong FROM KhenThuong_NhanVien JOIN KhenThuong ON KhenThuong_NhanVien.IdKhenThuong = KhenThuong.Id JOIN NhanVien ON KhenThuong_NhanVien.IdNhanVien = NhanVien.Id WHERE NhanVien.MaNhanVien =  @MaNhanVien", connectionn))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.selectedTienKhenThuong = Convert.ToString(reader["TienKhenThuong"]);
                                
                            }
                        }
                    }
                    using (SqlCommand command = new SqlCommand($"SELECT SUM(KiLuat.Tien) as TienKiLuat FROM KiLuat_NhanVien JOIN KiLuat ON KiLuat_NhanVien.IdKiLuat = KiLuat.Id JOIN NhanVien ON KiLuat_NhanVien.IdNhanVien = NhanVien.Id WHERE NhanVien.MaNhanVien =  @MaNhanVien", connectionn))
                    {
                        command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.selectedTienKiLuat = Convert.ToString(reader["TienKiLuat"]);

                            }
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            // Chuyển thông tin đã chọn sang cửa sổ ChamCong
            chamCongWindow.textBox1.Text = this.textBox1.Text;
            chamCongWindow.textBox2.Text = this.selectedMaLuong;
            chamCongWindow.textBox4.Text = this.selectedLuong;
            chamCongWindow.textBox3.Text = this.selectedPhuCap;
            chamCongWindow.textBox6.Text = this.selectedTienKhenThuong;
            chamCongWindow.textBox7.Text = this.selectedTienKiLuat;



            // Hiển thị cửa sổ ChamCong
            this.Close();

          
        }
    }

}

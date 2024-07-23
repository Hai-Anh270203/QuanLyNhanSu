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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Qlns
{
    public partial class BCTK : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        private KetNoi ketNoi = new KetNoi();
        public BCTK()
        {
            InitializeComponent();
        }

        private void BCTK_Load(object sender, EventArgs e)
        {
            HienThiBieuDoColumn();
            HienThiBieuDoPie();
            TongNhanVien();
            NVthuviec();
            NVSinhnhat();
            NVnghihuu();
        }
        private void TongNhanVien()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS TongNV FROM NhanVien WHERE NhanVien.Status = 1;";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        
                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            txtTongNV.Text = reader["TongNV"].ToString();
                            
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                        }

                        // Đóng reader sau khi sử dụng
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NVthuviec()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS thuviec " +
                                      "FROM NhanVien INNER JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id " +
                                      "Where LoaiHopDong = N'Hợp đồng thử việc';";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            txtThuViec.Text = reader["thuviec"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                        }

                        // Đóng reader sau khi sử dụng
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NVSinhnhat()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS sinhnhat FROM Users JOIN NhanVien ON NhanVien.IdUser = Users.Id WHERE NhanVien.Status = 1 AND DATEPART(MONTH, Users.NgaySinh) = DATEPART(MONTH, GETDATE());";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            txtSinhNhat.Text = reader["sinhnhat"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                        }

                        // Đóng reader sau khi sử dụng
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void NVnghihuu()
        {
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT COUNT(*) AS nghihuu " +
                                    "FROM Users JOIN NhanVien ON NhanVien.IdUser = Users.Id " +
                                    "WHERE Users.NgaySinh <= DATEADD(YEAR, -40, GETDATE());";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {

                        // Thực thi truy vấn và đọc dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Đọc dữ liệu từ các cột

                            txtNghiHuu.Text = reader["nghihuu"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin nhân viên!");
                        }

                        // Đóng reader sau khi sử dụng
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienThiBieuDoColumn()
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT " +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE LoaiHopDong= N'Hợp đồng thử việc') AS NVHopDong," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE LoaiHopDong= N'Hợp đồng có thời hạn') AS NV," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE LoaiHopDong= N'Hợp đồng không có thời hạn') AS NVNghiViec;";
                    using (cmd = new SqlCommand(query, connection))
                    {
                        reader = cmd.ExecuteReader();

                        // Xóa các chuỗi dữ liệu cũ (nếu có) và thêm chuỗi dữ liệu mới cho biểu đồ pie
                        BieuDo1.Series.Clear();
                        Series dataSeries = new Series("NhanVienData");
                        dataSeries.ChartType = SeriesChartType.Column;
                        BieuDo1.Series.Add(dataSeries);

                        while (reader.Read())
                        {
                            // Lấy số lượng nhân viên theo từng loại hợp đồng và nhân viên nghỉ việc
                            int NVHopDong = reader.GetInt32(reader.GetOrdinal("NVHopDong"));
                            int NV = reader.GetInt32(reader.GetOrdinal("NV"));
                            int NVNghiViec = reader.GetInt32(reader.GetOrdinal("NVNghiViec"));

                            // Thêm các điểm dữ liệu vào chuỗi dữ liệu của biểu đồ pie
                            dataSeries.Points.AddXY("Hợp đồng thử việc", NVHopDong);
                            dataSeries.Points.AddXY("Hợp đồng có thời hạn", NV);
                            dataSeries.Points.AddXY("Hợp đồng không có thời hạn", NVNghiViec);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu biểu đồ: " + ex.Message);
            }
            finally
            {
                // Đảm bảo rằng kết nối đã được đóng sau khi sử dụng
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void HienThiBieuDoPie()
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT " +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac LIKE '%Marketing%') AS Marketing," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac LIKE '%IT%') AS IT," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac=N'Kế toán') AS Ketoan," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac= N'Nhân sự') AS NS," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN CongTac ON NhanVien.IdCongTac = CongTac.Id WHERE CongTac.TenCongTac= N'Sales') AS Sales;";
                    using (cmd = new SqlCommand(query, connection))
                    {
                        reader = cmd.ExecuteReader();

                        // Xóa các chuỗi dữ liệu cũ (nếu có) và thêm chuỗi dữ liệu mới cho biểu đồ pie
                        BieuDo.Series.Clear();
                        Series dataSeries = new Series("NhanVienData");
                        dataSeries.ChartType = SeriesChartType.Pie;
                        BieuDo.Series.Add(dataSeries);

                        while (reader.Read())
                        {
                            // Lấy số lượng nhân viên theo từng loại hợp đồng và nhân viên nghỉ việc
                            int Marketing = reader.GetInt32(reader.GetOrdinal("Marketing"));
                            int IT = reader.GetInt32(reader.GetOrdinal("IT"));
                            int ketoan = reader.GetInt32(reader.GetOrdinal("Ketoan"));
                            int NS = reader.GetInt32(reader.GetOrdinal("NS"));
                            int Sales = reader.GetInt32(reader.GetOrdinal("Sales"));

                            // Thêm các điểm dữ liệu vào chuỗi dữ liệu của biểu đồ pie
                            dataSeries.Points.AddXY("Marketing", Marketing);
                            dataSeries.Points.AddXY("IT", IT);
                            dataSeries.Points.AddXY("Kế toán", ketoan);
                            dataSeries.Points.AddXY("Nhân sự", NS);
                            dataSeries.Points.AddXY("Sales", Sales);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu biểu đồ: " + ex.Message);
            }
            finally
            {
                // Đảm bảo rằng kết nối đã được đóng sau khi sử dụng
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}

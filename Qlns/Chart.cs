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

namespace Qlns
{
    public partial class Chart : Form
    {
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        public Chart()
        {
            InitializeComponent();
        }

        private void Cbchart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LoaiBieuDo=Cbchart.SelectedItem.ToString();
            switch(LoaiBieuDo)
            {
                case "Line":HienThiBieuDoLine();
                    break;
                case "Column":
                    // Hiển thị dữ liệu lên biểu đồ cột
                    HienThiBieuDoColumn();
                    break;
                case "Pie":
                    // Hiển thị dữ liệu lên biểu đồ hình tròn
                    HienThiBieuDoPie();
                    break;
                case "Bar":
                    // Hiển thị dữ liệu lên biểu đồ hình tròn
                    HienThiBieuDoBar();
                    break;
                    // Thêm các trường hợp xử lý khác cho các loại biểu đồ khác (nếu cần)
            }
        }
        private void HienThiBieuDoLine()
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT " +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE HopDong.LoaiHopDong LIKE '%Hợp đồng%') AS NVHopDong," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE HopDong.LoaiHopDong LIKE '%Chính thức%') AS NV," +
                                   "(SELECT COUNT(*) FROM NhanVien WHERE NhanVien.Status = 0) AS NVNghiViec;";
                    using (cmd = new SqlCommand(query, connection))
                    {
                        reader = cmd.ExecuteReader();

                        // Xóa các chuỗi dữ liệu cũ (nếu có) và thêm chuỗi dữ liệu mới cho biểu đồ pie
                        BieuDo.Series.Clear();
                        //Color 
                        Color[] colors = { Color.Red, Color.Blue, Color.Green };

                        Series dataSeries = new Series("NhanVienData");
                        dataSeries.ChartType = SeriesChartType.Line;
                        BieuDo.Series.Add(dataSeries);

                        while (reader.Read())
                        {
                            // Lấy số lượng nhân viên theo từng loại hợp đồng và nhân viên nghỉ việc
                            int NVHopDong = reader.GetInt32(reader.GetOrdinal("NVHopDong"));
                            int NV = reader.GetInt32(reader.GetOrdinal("NV"));
                            int NVNghiViec = reader.GetInt32(reader.GetOrdinal("NVNghiViec"));

                            // Thêm các điểm dữ liệu vào chuỗi dữ liệu của biểu đồ pie
                            dataSeries.Points.AddXY("NV Hợp đồng", NVHopDong);
                            dataSeries.Points.AddXY("NV Chính thức", NV);
                            dataSeries.Points.AddXY("NV Nghỉ việc", NVNghiViec);
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
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE HopDong.LoaiHopDong LIKE '%Hợp đồng%') AS NVHopDong," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE HopDong.LoaiHopDong LIKE '%Chính thức%') AS NV," +
                                   "(SELECT COUNT(*) FROM NhanVien WHERE NhanVien.Status = 0) AS NVNghiViec;";
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
                            int NVHopDong = reader.GetInt32(reader.GetOrdinal("NVHopDong"));
                            int NV = reader.GetInt32(reader.GetOrdinal("NV"));
                            int NVNghiViec = reader.GetInt32(reader.GetOrdinal("NVNghiViec"));

                            // Thêm các điểm dữ liệu vào chuỗi dữ liệu của biểu đồ pie
                            dataSeries.Points.AddXY("NV Hợp đồng", NVHopDong);
                            dataSeries.Points.AddXY("NV Chính thức", NV);
                            dataSeries.Points.AddXY("NV Nghỉ việc", NVNghiViec);
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
        private void HienThiBieuDoColumn()
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT " +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE LoaiHopDong= N'Hợp đồng có thời hạn') AS NVHopDong," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE HopDong.LoaiHopDong LIKE '%Chính thức%') AS NV," +
                                   "(SELECT COUNT(*) FROM NhanVien WHERE NhanVien.Status = 0) AS NVNghiViec;";
                    using (cmd = new SqlCommand(query, connection))
                    {
                        reader = cmd.ExecuteReader();

                        // Xóa các chuỗi dữ liệu cũ (nếu có) và thêm chuỗi dữ liệu mới cho biểu đồ pie
                        BieuDo.Series.Clear();
                        Series dataSeries = new Series("NhanVienData");
                        dataSeries.ChartType = SeriesChartType.Column;
                        BieuDo.Series.Add(dataSeries);

                        while (reader.Read())
                        {
                            // Lấy số lượng nhân viên theo từng loại hợp đồng và nhân viên nghỉ việc
                            int NVHopDong = reader.GetInt32(reader.GetOrdinal("NVHopDong"));
                            int NV = reader.GetInt32(reader.GetOrdinal("NV"));
                            int NVNghiViec = reader.GetInt32(reader.GetOrdinal("NVNghiViec"));

                            // Thêm các điểm dữ liệu vào chuỗi dữ liệu của biểu đồ pie
                            dataSeries.Points.AddXY("NV Hợp đồng", NVHopDong);
                            dataSeries.Points.AddXY("NV Chính thức", NV);
                            dataSeries.Points.AddXY("NV Nghỉ việc", NVNghiViec);
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

        //Hien Thi bieu do bar
        private void HienThiBieuDoBar()
        {
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT " +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE HopDong.LoaiHopDong LIKE '%Hợp đồng%') AS NVHopDong," +
                                   "(SELECT COUNT(*) FROM NhanVien JOIN HopDong ON NhanVien.IdHopDong = HopDong.Id WHERE HopDong.LoaiHopDong LIKE '%Chính thức%') AS NV," +
                                   "(SELECT COUNT(*) FROM NhanVien WHERE NhanVien.Status = 0) AS NVNghiViec;";
                    using (cmd = new SqlCommand(query, connection))
                    {
                        reader = cmd.ExecuteReader();

                        // Xóa các chuỗi dữ liệu cũ (nếu có) và thêm chuỗi dữ liệu mới cho biểu đồ pie
                        BieuDo.Series.Clear();
                        Series dataSeries = new Series("NhanVienData");
                        dataSeries.ChartType = SeriesChartType.Bar;
                        BieuDo.Series.Add(dataSeries);

                        while (reader.Read())
                        {
                            // Lấy số lượng nhân viên theo từng loại hợp đồng và nhân viên nghỉ việc
                            int NVHopDong = reader.GetInt32(reader.GetOrdinal("NVHopDong"));
                            int NV = reader.GetInt32(reader.GetOrdinal("NV"));
                            int NVNghiViec = reader.GetInt32(reader.GetOrdinal("NVNghiViec"));

                            // Thêm các điểm dữ liệu vào chuỗi dữ liệu của biểu đồ pie
                            dataSeries.Points.AddXY("NV Hợp đồng", NVHopDong);
                            dataSeries.Points.AddXY("NV Chính thức", NV);
                            dataSeries.Points.AddXY("NV Nghỉ việc", NVNghiViec);
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
        private void BieuDo_Click(object sender, EventArgs e)
        {

        }
    }
}

using Qlns.DAL;
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
    public partial class ThemBaoHiem1 : Form
    {
        ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();
        public ThemBaoHiem1()
        {
            InitializeComponent();
        }

        private void ThemBaoHiem1_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection connection = Kn.OpenConnection())

                {
                    string query = "SELECT * FROM NhanVien"; // Chọn chỉ các cột cần thiết
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Kiểm tra xem có dữ liệu được trả về không
                        if (dataTable.Rows.Count > 0)
                        {
                            // Gán dữ liệu vào ComboBox
                            cboMaNhanVien.DataSource = dataTable;
                            cboMaNhanVien.DisplayMember = "Id";
                            cboMaNhanVien.ValueMember = "Id";
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nhân viên.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu nhân viên: " + ex.Message);
            }
        }

        private void btnThemBH_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem ComboBox đã chọn một mục nào chưa
            if (cboMaNhanVien.SelectedValue != null)
            {
                // Chuyển đổi giá trị ngày từ DateTimePicker sang chuỗi đúng định dạng
                string ngayCap = DateNgayCap.Value.ToString("yyyyMMdd");

                // Lấy các giá trị từ các điều khiển trên giao diện và truyền vào phương thức ThemBaoHiem
                BaoHiemDAL baoHiemDAL = new BaoHiemDAL();
                baoHiemDAL.ThemBaoHiem(ngayCap, txtGhiChu.Text, Convert.ToInt32(txtTienBaoHiem.Text), Convert.ToInt32(cboMaNhanVien.SelectedValue), txtNoiCap.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu có lựa chọn
                if (cboMaNhanVien.SelectedValue != null)
                {
                    // Kết nối đến cơ sở dữ liệu
                    using (SqlConnection ketnoi = Kn.OpenConnection())
                    {
                        // Lấy giá trị được chọn từ ComboBox
                        int selectedMaNhanVien;
                        if (int.TryParse(cboMaNhanVien.SelectedValue.ToString(), out selectedMaNhanVien))
                        {
                            // Truy vấn SQL để lấy thông tin nhân viên dựa trên mã nhân viên được chọn
                            string query = "SELECT * FROM Users INNER JOIN NhanVien ON NhanVien.IdUser = Users.Id WHERE NhanVien.Id = @Id";
                            SqlCommand cmd = new SqlCommand(query, ketnoi);
                            cmd.Parameters.AddWithValue("@Id", selectedMaNhanVien);

                            // Sử dụng SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();

                            // Đổ dữ liệu vào DataTable từ SqlDataAdapter
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                // Hiển thị thông tin nhân viên trong TextBoxes
                                txtTenNhanVien.Text = Convert.ToString(dataTable.Rows[0]["HoTen"]);
                                // Hiển thị thông tin user
                                // Ví dụ:
                                // txtUserName.Text = Convert.ToString(dataTable.Rows[0]["UserName"]);
                                // txtEmail.Text = Convert.ToString(dataTable.Rows[0]["Email"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }
    }
}

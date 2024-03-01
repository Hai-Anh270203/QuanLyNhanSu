using Qlns.DAL;
using Qlns.DTO;
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
    public partial class TienLuong : Form
    {
        public TienLuong()
        {
            InitializeComponent();
        }
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            TienLuongDAL tienLuongDAL = new TienLuongDAL();
            int Id = tienLuongDAL.AddTL(txtBacLuong.Text, txtHeSo.Text, txtPhuCap.Text, txtLuongCong.Text, txtGhiChu.Text);

            if (Id >= 0)
            {
                TienLuong_Load(sender, e);
                MessageBox.Show("Thêm bậc lương thành công");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm bậc lương.");
            }
        }

        private void TienLuong_Load(object sender, EventArgs e)
        {
            DAL.TienLuongDAL tienLuongDAL = new DAL.TienLuongDAL();
            List<TienLuongDTO> tienLuongDTOs = tienLuongDAL.LayTienLuong();
            DGVTienLuong.DataSource = tienLuongDTOs;
            DGVsua.DataSource = tienLuongDTOs;

            // Load MaLuong
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM TienLuong";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cbMaLuong.DataSource = dataTable;
                    cbMaLuong.DisplayMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            if (DGVTienLuong.Rows.Count > 0)
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < DGVTienLuong.Columns.Count + 1; i++)
                {
                    excel.Cells[1, i] = DGVTienLuong.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < DGVTienLuong.Rows.Count; i++)
                {
                    for (int j = 0; j < DGVTienLuong.Columns.Count; j++)
                    {
                        excel.Cells[i + 2, j + 1] = DGVTienLuong.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excel.Columns.AutoFit();
                excel.Visible = true;
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            DAL.TienLuongDAL tienLuongDAL = new DAL.TienLuongDAL();
            List<TienLuongDTO> tienLuongDTOs = tienLuongDAL.LayTienLuong();
            DGVTienLuong.DataSource = tienLuongDTOs;
        }

        private void btnUp_Click_1(object sender, EventArgs e)
        {
            DAL.TienLuongDAL tienLuongDAL = new DAL.TienLuongDAL();
            List<TienLuongDTO> tienLuongDTOs = tienLuongDAL.LayTienLuong();
            DGVsua.DataSource = tienLuongDTOs;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox
            int Id = int.Parse(cbMaLuong.Text);

            // Tạo một thể hiện của lớp TienLuongDAL
            TienLuongDAL tienLuongDAL = new TienLuongDAL();

            // Gọi phương thức SuaTL với các tham số tương ứng
            int sua = tienLuongDAL.XoaTL(Id);

            // Kiểm tra kết quả trả về từ hàm
            if (sua >= 0)
            {
                TienLuong_Load(sender, e);
                MessageBox.Show("Xoa bậc lương thành công");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi xóa bậc lương.");
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox
            int Id = int.Parse(cbMaLuong.Text);
            string BacLuong = txtBL.Text;
            string HeSo = txtHS.Text;
            string PhuCap = txtPC.Text;
            string LuongCong = txtLC.Text;
            string GhiChu = txtGC.Text;

            // Tạo một thể hiện của lớp TienLuongDAL
            TienLuongDAL tienLuongDAL = new TienLuongDAL();

            // Gọi phương thức SuaTL với các tham số tương ứng
            int sua = tienLuongDAL.SuaTL(Id, BacLuong, HeSo, PhuCap,LuongCong, GhiChu);

            // Kiểm tra kết quả trả về từ hàm
            if (sua >= 0)
            {
                TienLuong_Load(sender, e);
                MessageBox.Show("Sửa bậc lương thành công");
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa bậc lương.");
            }
        }

        private void cbMaLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView view = (DataRowView)cbMaLuong.SelectedItem;
            txtBL.Text = view["BacLuong"].ToString();
            txtHS.Text = view["HeSo"].ToString();
            txtPC.Text = view["PhuCap"].ToString();
            txtLC.Text = view["LuongCong"].ToString();
            txtGC.Text = view["GhiChu"].ToString();
        }
    }
}

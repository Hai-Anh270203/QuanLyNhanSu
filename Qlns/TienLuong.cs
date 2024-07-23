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
using System.Windows.Forms.DataVisualization.Charting;

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

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
          /*  Microsoft.Office.Interop.Excel.Application excel;
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
            }*/
        }

        private void DGVTienLuong_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVTienLuong.SelectedCells.Count > 0)
            {
                int selectedrowindex = DGVTienLuong.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGVTienLuong.Rows[selectedrowindex];

                string Id = Convert.ToString(selectedRow.Cells["Id"].Value);
                string HeSo = Convert.ToString(selectedRow.Cells["HeSo"].Value);
                string BacLuong = Convert.ToString(selectedRow.Cells["BacLuong"].Value);
                string LuongCong = Convert.ToString(selectedRow.Cells["LuongCong"].Value);
                string PhuCap = Convert.ToString(selectedRow.Cells["PhuCap"].Value);
                string GhiChu = Convert.ToString(selectedRow.Cells["GhiChu"].Value);


                txtMaLuong.Text = Id;
                txtHeSo.Text = HeSo;
                txtBacLuong.Text = BacLuong;
                txtLuongCong.Text = LuongCong;
                txtPhuCap.Text = PhuCap;
                txtGhiChu.Text = GhiChu;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox
            int Id = int.Parse(txtMaLuong.Text);
            string BacLuong = txtBacLuong.Text;
            string HeSo = txtHeSo.Text;
            string PhuCap = txtPhuCap.Text;
            string LuongCong = txtLuongCong.Text;
            string GhiChu = txtGhiChu.Text;

            // Tạo một thể hiện của lớp TienLuongDAL
            TienLuongDAL tienLuongDAL = new TienLuongDAL();

            // Gọi phương thức SuaTL với các tham số tương ứng
            int sua = tienLuongDAL.SuaTL(Id, BacLuong, HeSo, PhuCap, LuongCong, GhiChu);

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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox
            int Id = int.Parse(txtMaLuong.Text);

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
    }
}

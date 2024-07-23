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
    public partial class NV_KhenThuong : Form
    {
        public NV_KhenThuong()
        {
            InitializeComponent();
        }
        private KetNoi ketNoi = new KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        private void NV_KhenThuong_Load(object sender, EventArgs e)
        {
            string ma = DangNhap.MaNhanVien;
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT NhanVien.MaNhanVien, KhenThuong.Id, KhenThuong.KhenThuong,KhenThuong.Tien " +
                                      "FROM KhenThuong_NhanVien " +
                                      "INNER JOIN KhenThuong ON KhenThuong_NhanVien.IdKhenThuong = KhenThuong.Id  " +
                                      "INNER JOIN NhanVien ON KhenThuong_NhanVien.IdNhanVien = NhanVien.Id " +
                                      "WHERE MaNhanVien = N'" + ma + "'";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Tạo DataTable để chứa dữ liệu
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Gán DataTable vào DataSource của DataGridView
                        DGVkhen.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}

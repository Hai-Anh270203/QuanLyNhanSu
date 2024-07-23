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
    public partial class NV_KiLuat : Form
    {
        public NV_KiLuat()
        {
            InitializeComponent();
        }
        private KetNoi ketNoi = new KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        private void NV_KiLuat_Load(object sender, EventArgs e)
        {
            string ma = DangNhap.MaNhanVien;
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT NhanVien.MaNhanVien, KiLuat.Id, KiLuat.KiLuat, KiLuat.Tien " +
                                      "FROM KiLuat " +
                                      "INNER JOIN KiLuat_NhanVien ON KiLuat.Id = KiLuat_NhanVien.IdKiLuat " +
                                      "INNER JOIN NhanVien ON KiLuat_NhanVien.IdNhanVien = NhanVien.Id " +
                                      "WHERE MaNhanVien = N'" + ma + "'";


                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);

                        SqlDataReader reader = cmd.ExecuteReader();

                        // Tạo DataTable để chứa dữ liệu
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Gán DataTable vào DataSource của DataGridView
                        DGVkiluat.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

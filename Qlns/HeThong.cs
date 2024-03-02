using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Qlns
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        private void HeThong_Load(object sender, EventArgs e)
        {

            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT NhanVien.MaNhanVien, Users.HoTen FROM NhanVien INNER JOIN Users ON NhanVien.IdUser = Users.Id";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cbMaNV.DataSource = dataTable;
                    cbMaNV.DisplayMember = "MaNhanVien";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "SELECT * FROM Role";
                    cmd = new SqlCommand(query, connection);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cbRole.DataSource = dataTable;
                    cbRole.DisplayMember = "Role";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hiện tên khi chọn mã nhân viên 
        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView view = (DataRowView)cbMaNV.SelectedItem;
            string hoTen = view["HoTen"].ToString();
            txtTenNV.Text = hoTen;
        }
        
        //Thêm tài khoản

        //Sửa tài khoản 

        //Xóa tài khoản


    }
}

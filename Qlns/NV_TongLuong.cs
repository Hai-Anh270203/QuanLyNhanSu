using Guna.UI2.WinForms;
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
    public partial class NV_TongLuong : Form
    {
        public NV_TongLuong()
        {
            InitializeComponent();
        }
        private KetNoi ketNoi = new KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        private void NV_TongLuong_Load(object sender, EventArgs e)
        {
            string ma = DangNhap.MaNhanVien;
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT NhanVien.MaNhanVien, NgayCong.CongNgay, NgayCong.GioLamThem " +
                                      "FROM NgayCong INNER JOIN NhanVien ON NgayCong.IdNhanVien = NhanVien.Id " +
                                      "WHERE MaNhanVien = N'" + ma + "' AND NgayCong.CongNgay IS NOT NULL AND NgayCong.GioLamThem IS NOT NULL";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        DGVTongluong.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT NhanVien.MaNhanVien, NgayCong.NgayNghi " +
                                      "FROM NgayCong INNER JOIN NhanVien ON NgayCong.IdNhanVien = NhanVien.Id " +
                                      "WHERE MaNhanVien = N'" + ma + "' AND NgayCong.NgayNghi IS NOT NULL";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        DGVNghi.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT MaNhanVien, TongLuong, Thang, Nam " +
                                      "FROM LuongThang " +
                                      "WHERE MaNhanVien = N'" + ma + "'";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        DGVluong.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string thang = cboThang.Text;

            string ma = DangNhap.MaNhanVien;
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT NhanVien.MaNhanVien, NgayCong.CongNgay, NgayCong.GioLamThem " +
                                      "FROM NgayCong CROSS JOIN NhanVien " +
                                      "WHERE MaNhanVien = N'" + ma + "' AND MONTH(NgayCong.CongNgay) = @Thang";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                        cmd.Parameters.AddWithValue("@Thang", cboThang.SelectedItem);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        DGVTongluong.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT NhanVien.MaNhanVien, NgayCong.NgayNghi " +
                                      "FROM NgayCong CROSS JOIN NhanVien " +
                                      "WHERE MaNhanVien = N'" + ma + "' AND MONTH(NgayCong.NgayNghi) = @Thang";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                        cmd.Parameters.AddWithValue("@Thang", thang);
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        DGVNghi.DataSource = dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    string sqlQuery = "SELECT MaNhanVien, TongLuong, Thang, Nam " +
                                      "FROM LuongThang " +
                                      "WHERE MaNhanVien = N'" + ma + "'AND LuongThang.Thang = @Thang";

                    using (SqlCommand cmd = new SqlCommand(sqlQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNhanVien", ma);
                        cmd.Parameters.AddWithValue("@Thang", thang);

                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        DGVluong.DataSource = dataTable;
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


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
    public partial class NV_ChamCong : Form
    {
        private KetNoi ketNoi = new KetNoi();
        string manv = DangNhap.MaNhanVien;
        int idNhanVien;
        public NV_ChamCong()
        {
            InitializeComponent();
        }

        private void NV_ChamCong_Load(object sender, EventArgs e)
        {
            Ngay.Format = DateTimePickerFormat.Short;
            Nghi.Format = DateTimePickerFormat.Short;
            GioVao.Format = DateTimePickerFormat.Time;
            GioVao.ShowUpDown = true;
            GioRa.Format = DateTimePickerFormat.Time;
            GioRa.ShowUpDown = true;
        }

        private void btnNgay_Click(object sender, EventArgs e)
        {
            DateTime Vao = Ngay.Value.Date + GioVao.Value.TimeOfDay;
            DateTime Ra = Ngay.Value.Date + GioRa.Value.TimeOfDay;

            string gioVao = Vao.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string gioRa = Ra.ToString("yyyy-MM-dd HH:mm:ss.fff");

            using (SqlConnection connection = ketNoi.OpenConnection())

            using (SqlCommand command = new SqlCommand("SELECT Id FROM NhanVien WHERE MaNhanVien = @maNhanVien", connection))
            {
                command.Parameters.AddWithValue("@maNhanVien", manv);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idNhanVien = reader.GetInt32(0);
                    }
                    else
                    {
                        throw new Exception("Không tìm thấy nhân viên với mã: " + manv);
                    }
                }
            }

            using (SqlConnection connection = ketNoi.OpenConnection())
            using (SqlCommand command = new SqlCommand("INSERT INTO ChamCong (GioVao, GioRa,IdNhanVien) VALUES (@gioVao, @gioRa, @IDNV)", connection))
            {
                command.Parameters.AddWithValue("@gioVao", gioVao);
                command.Parameters.AddWithValue("@gioRa", gioRa);
                command.Parameters.AddWithValue("@IDNV", idNhanVien);

                command.ExecuteNonQuery();
            }
            TimeSpan duration = Ra - Vao;
            int hoursWorked = (int)duration.TotalHours;
            int overtime = Math.Max(0, hoursWorked - 8);

            string congNgay = hoursWorked >= 8 ? Vao.ToString("yyyy-MM-dd") : null;

            using (SqlConnection connection = ketNoi.OpenConnection())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO NgayCong (IdNhanVien, CongNgay, GioLamThem) VALUES (@IDNV, @CongNgay, @GioLamThem)", connection))
                {
                    command.Parameters.AddWithValue("@IDNV", idNhanVien);
                    command.Parameters.AddWithValue("@CongNgay", congNgay ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@GioLamThem", overtime);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNghi_Click(object sender, EventArgs e)
        {
            string Ngaynghi = Nghi.Value.ToString("yyyy-MM-dd");
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nghỉ phép không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = ketNoi.OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand("INSERT INTO NgayCong (IdNhanVien,NgayNghi) VALUES (@IDNV, @NgayNghi)", connection))
                    {
                        command.Parameters.AddWithValue("@IDNV", idNhanVien);
                        command.Parameters.AddWithValue("@NgayNghi", Ngaynghi);

                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

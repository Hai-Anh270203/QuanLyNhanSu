using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class HopDongDAL
    {
        ConnectDB.KetNoi kn = new ConnectDB.KetNoi();
        SqlConnection connection = null;
        SqlDataReader reader = null;
        SqlCommand cmd = null;
        SqlDataAdapter adapter = null;
        public int AddHopDong(string LoaiHopDong ,string NgayBatDau ,string NgayKetThuc)
        {
            int IdHopDong;
            try
            {
                using (connection = kn.OpenConnection())
                {
                    string query = "INSERT INTO HopDong(LoaiHopDong ,NgayBatDau ,NgayKetThuc)"
                                  + "VALUES (@LoaiHopDong,@NgayBatDau ,@NgayKetThuc)"
                                  + "SELECT SCOPE_IDENTITY() AS IdHopDonh";
                    using (cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@LoaiHopDong" ,LoaiHopDong);
                        cmd.Parameters.AddWithValue("@NgayBatDau", NgayBatDau);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", NgayKetThuc);
                        IdHopDong =Convert.ToInt32(cmd.ExecuteScalar());
                        return IdHopDong;
                    }
                }
                  
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
           
        }
    }
}

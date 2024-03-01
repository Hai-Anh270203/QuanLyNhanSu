using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.ConnectDB
{
    internal class KetNoi
    {
        string ConnectionStr = @"Data Source=DESKTOP-A4AQPRU\SQLEXPRESS;Initial Catalog=QLNS4;Persist Security Info=True;User ID=HaiAnhdeptrai;Password=1;";
        public SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(ConnectionStr);

            try
            {
                // Mở kết nối
                connection.Open();
                Console.WriteLine("Kết nối thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi kết nối: " + ex.Message);
                MessageBox.Show("not ok");
            }

            return connection;
        }
        // Hàm đóng kết nối
        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                // Đóng kết nối
                connection.Close();
                Console.WriteLine("Đóng kết nối thành công!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }

    }
}

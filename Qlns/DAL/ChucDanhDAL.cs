using Qlns.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlns.DAL
{
    internal class ChucDanhDAL
    {
        ConnectDB.KetNoi Kn = new ConnectDB.KetNoi();
        public List<DTO.ChucDanhDTO> LayChucDanh()
        {
            List<DTO.ChucDanhDTO> ChucDanhList = new List<ChucDanhDTO>();


            SqlConnection ketnoi = Kn.OpenConnection();
            string query = "SELECT * FROM ChucDanh";
            SqlCommand cmd = new SqlCommand(query, ketnoi);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                DTO.ChucDanhDTO CD = new DTO.ChucDanhDTO()
                {
                    Id = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Id")),
                    TenChucDanh=sqlDataReader.GetString(sqlDataReader.GetOrdinal("TenChucDanh")),
                    Status =sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Status")),
                };
                // Process or use the ChucDanhDTO object here
                ChucDanhList.Add(CD);
            }
       
            return ChucDanhList;

        }
    }
    }


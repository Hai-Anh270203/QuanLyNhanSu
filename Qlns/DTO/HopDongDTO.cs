using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlns.DTO
{
    internal class HopDongDTO
    {
        public int Id { get; set; }
        public string LoaiHopDong { get; set; }   
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}

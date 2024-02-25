using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlns.DTO
{
    internal class TienLuongDTO
    {
        public int Id { get; set; }
        public int BacLuong { get; set; }
        public float HeSo { get; set; }
        public float PhuCap { get; set; }
        public string GhiChu { get; set; }
        public string status { get; set; }
    }
}

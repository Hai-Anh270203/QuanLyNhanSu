﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlns.DTO
{
    internal class TaiKhoanDTO
    {
        public int IdUser { get; set; }
        public int IdUserRole { get; set; }
        public string MaNhanVien { get;set; }
        public string HoTen { get; set; }
        public string MatKhau { get; set; }
        public string Role { get; set;}
    }
}

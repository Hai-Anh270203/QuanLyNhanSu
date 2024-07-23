using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlns.DTO
{
    internal class NhanVienDTO
    {
        public int IdUser { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string DiaChi { get; set; }
        public string DangVien { get; set; }
        public string HocVan { get; set; }
        public int IdTienLuong { get; set; }
        public int IdChucDanh { get; set; }
        public int IdCongTac { get; set; }
        public string TenCongTac { get; set; }
        public string TenChucDanh { get; set; }
        public string LoaiHopDong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string MaNhanVien { get; set; }

        public int IdNhanVien { get; set; }
        public string DuongDan { get; set; }
        public int IdHopDong { get; set; }


    }

    internal class NhanVienDTO2
    {
        public int IdNhanVien { get; set; }
        public int IdUser { get; set; }
        public string MaNhanVien { get; set; }
        public string IdChucDanh { get; set; }
        public string IdTienLuong { get; set; }
        public string IdHopDong { get; set; }
        public string IdCongTac { get; set; }

    }
    //Thong Ke nhan vien
    internal class ThongKe
    {
        public int Nv { get; set; }
        public int NvNghiViec { get; set; }
        public int NvHopDong { get; set; }


    }
}

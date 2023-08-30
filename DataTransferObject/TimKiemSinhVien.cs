using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTransferObject
{
    public class TimKiemSinhVien
    {
        public string MSSV { get; set; }
        public string HoDem { get; set; }
        public string Ten { get; set; }
        public string MaLop { get; set; }
        public DateTime NgaySinh { get; set; }
        public byte GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public TimKiemSinhVien(string mSSV, string hoDem, string ten, string maLop, DateTime ngaySinh, byte gioiTinh, string diaChi)
        {
            MSSV = mSSV;
            HoDem = hoDem;
            Ten = ten;
            MaLop = maLop;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }

        public TimKiemSinhVien() { }
    }
}

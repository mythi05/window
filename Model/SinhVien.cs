using System;

namespace MyThi_490.Model
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; } // Nam/Nữ
        public string Khoa { get; set; }     // Tên khoa
        public string Lop { get; set; }      // Tên lớp
        public string SDT { get; set; }      // Mặc định rỗng vì chưa có ô nhập
        public DateTime NgaySinh { get; set; } // Mặc định hôm nay vì chưa có ô nhập

        public SinhVien() { }

        public SinhVien(string ma, string ten, string gt, string khoa, string lop)
        {
            this.MaSV = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.Khoa = khoa;
            this.Lop = lop;
            this.SDT = "";
            this.NgaySinh = DateTime.Now;
        }
    }
}
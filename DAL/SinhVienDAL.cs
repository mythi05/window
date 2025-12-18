using System.Collections.Generic;
using System.Linq; // Cần thư viện này để dùng .FirstOrDefault
using MyThi_490.Model;

namespace MyThi_490.DAL
{
    public class SinhVienDAL
    {
        private static List<SinhVien> listSV;

        public SinhVienDAL()
        {
            if (listSV == null)
            {
                listSV = new List<SinhVien>();
       
                listSV.Add(new SinhVien("SV001", "Nguyễn Văn ", "Nam", "CNTT", "20DTH1"));
                listSV.Add(new SinhVien("SV002", "Đỗ Thị Mỹ Thi ", "Nữ", "Kế Toán", "20KKT1"));
            }
        }

        public List<SinhVien> GetAll()
        {
            return listSV;
        }

        public bool Add(SinhVien sv)
        {
            // Kiểm tra trùng mã
            if (listSV.Any(x => x.MaSV == sv.MaSV)) return false;

            listSV.Add(sv);
            return true;
        }

        public bool Delete(string maSV)
        {
            var sv = listSV.FirstOrDefault(x => x.MaSV == maSV);
            if (sv != null)
            {
                listSV.Remove(sv);
                return true;
            }
            return false;
        }

        public bool Update(SinhVien svMoi)
        {
            var svCu = listSV.FirstOrDefault(x => x.MaSV == svMoi.MaSV);
            if (svCu != null)
            {
                svCu.HoTen = svMoi.HoTen;
                svCu.GioiTinh = svMoi.GioiTinh;
                svCu.Khoa = svMoi.Khoa;
                svCu.Lop = svMoi.Lop;
                return true;
            }
            return false;
        }
    }
}
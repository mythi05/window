using System.Collections.Generic;
using MyThi_490.DAL;
using MyThi_490.Model;

namespace MyThi_490.BLL
{
    public class KetQuaBLL
    {
        KetQuaDAL dal = new KetQuaDAL();

        public List<KetQua> GetList() => dal.GetAll();

      

        public string NhapDiem(string masv, string mamon, float diem)
        {
            if (diem < 0 || diem > 10) return "Điểm phải từ 0 đến 10!";

            if (dal.CapNhatDiem(masv, mamon, diem)) return "Nhập điểm thành công!";
            return "Sinh viên chưa đăng ký môn này!";
        }

        
    }
}
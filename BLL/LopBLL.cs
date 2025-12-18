using System.Collections.Generic;
using MyThi_490.DAL;
using MyThi_490.Model;

namespace MyThi_490.BLL
{
    public class LopBLL
    {
        LopDAL dal = new LopDAL();

        public List<Lop> GetList() => dal.GetAll();

        public string ThemMoi(Lop lop)
        {
            if (string.IsNullOrEmpty(lop.MaLop) || string.IsNullOrEmpty(lop.TenLop))
                return "Nhập thiếu thông tin!";

            if (dal.Add(lop)) return "Thêm thành công";
            return "Mã lớp đã tồn tại";
        }

        public string Sua(Lop lop)
        {
            if (dal.Update(lop)) return "Sửa thành công";
            return "Không tìm thấy lớp";
        }

        public string Xoa(string ma)
        {
            if (dal.Delete(ma)) return "Xóa thành công";
            return "Lỗi xóa";
        }
    }
}
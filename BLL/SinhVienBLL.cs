using System.Collections.Generic;
using MyThi_490.DAL;
using MyThi_490.Model;

namespace MyThi_490.BLL
{
    public class SinhVienBLL
    {
        SinhVienDAL dal = new SinhVienDAL();

        public List<SinhVien> GetListSV()
        {
            return dal.GetAll();
        }

        public string ThemMoi(SinhVien sv)
        {
            if (string.IsNullOrEmpty(sv.MaSV) || string.IsNullOrEmpty(sv.HoTen))
                return "Vui lòng nhập đủ thông tin!";

            if (dal.Add(sv))
                return "Thêm thành công!";
            else
                return "Mã sinh viên đã tồn tại!";
        }

        public string Xoa(string maSV)
        {
            if (dal.Delete(maSV))
                return "Xóa thành công!";
            else
                return "Không tìm thấy sinh viên!";
        }

        public string Sua(SinhVien sv)
        {
            if (dal.Update(sv))
                return "Cập nhật thành công!";
            else
                return "Không tìm thấy sinh viên để sửa!";
        }
    }
}
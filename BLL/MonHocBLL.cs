using System.Collections.Generic;
using MyThi_490.DAL;
using MyThi_490.Model;

namespace MyThi_490.BLL
{
    public class MonHocBLL
    {
        MonHocDAL dal = new MonHocDAL();

        public List<MonHoc> GetList() => dal.GetAll();

        public string ThemMoi(MonHoc mh)
        {
            if (string.IsNullOrEmpty(mh.MaMon) || string.IsNullOrEmpty(mh.TenMon))
                return "Vui lòng nhập Mã và Tên môn!";

            if (mh.SoTinChi <= 0)
                return "Số tín chỉ phải lớn hơn 0";

            if (dal.Add(mh)) return "Thêm thành công";
            return "Mã môn học đã tồn tại";
        }

        public string Sua(MonHoc mh)
        {
            if (dal.Update(mh)) return "Cập nhật thành công";
            return "Không tìm thấy môn học để sửa";
        }

        public string Xoa(string ma)
        {
            if (dal.Delete(ma)) return "Xóa thành công";
            return "Không tìm thấy môn học";
        }
    }
}
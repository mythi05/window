using System.Collections.Generic;
using MyThi_490.DAL;
using MyThi_490.Model;

namespace MyThi_490.BLL
{
    public class CoVanBLL
    {
        CoVanDAL dal = new CoVanDAL();

        public List<CoVan> GetList() => dal.GetAll();

        public string ThemMoi(CoVan cv)
        {
            if (string.IsNullOrEmpty(cv.MaCV) || string.IsNullOrEmpty(cv.TenCV))
                return "Vui lòng nhập đủ thông tin!";

            if (dal.Add(cv)) return "Thêm thành công";
            return "Mã cố vấn đã tồn tại";
        }
         
        public string Sua(CoVan cv)
        {
            if (dal.Update(cv)) return "Cập nhật thành công";
            return "Không tìm thấy cố vấn";
        }

        public string Xoa(string ma)
        {
            if (dal.Delete(ma)) return "Xóa thành công";
            return "Không tìm thấy cố vấn";
        }
        
    }
}
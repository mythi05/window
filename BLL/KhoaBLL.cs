using System.Collections.Generic;
using MyThi_490.DAL;
using MyThi_490.Model;

namespace MyThi_490.BLL
{
    public class KhoaBLL
    {
        KhoaDAL dal = new KhoaDAL();

        public List<Khoa> GetList()
        {
            return dal.GetAllKhoa();
        }

        public void ThemMoi(string ma, string ten)
        {
            Khoa k = new Khoa(ma.ToUpper(), ten);
            dal.AddKhoa(k);
        }
        public void Sua(string ma, string ten)
        {
            Khoa k = new Khoa(ma.ToUpper(), ten);
            dal.UpdateKhoa(k);
        }
        public void Xoa(string ma)
        {
            dal.DeleteKhoa(ma.ToUpper());
        }
    }
}
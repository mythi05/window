using System.Collections.Generic;
using MyThi_490.Model; 

namespace MyThi_490.DAL
{
    public class KhoaDAL
    {
      
        private static List<Khoa> listKhoa;

        public KhoaDAL()
        {
       
            if (listKhoa == null)
            {
                listKhoa = new List<Khoa>();
                listKhoa.Add(new Khoa("CNTT", "Công nghệ thông tin"));
                listKhoa.Add(new Khoa("KT", "Kế toán"));
                listKhoa.Add(new Khoa("QTKD", "Quản trị kinh doanh"));
            }
        }

        public List<Khoa> GetAllKhoa()
        {
            return listKhoa;
        }

    
        public void AddKhoa(Khoa khoa)
        {
            listKhoa.Add(khoa);
        }

        public void UpdateKhoa(Khoa khoa)
        {
            for (int i = 0; i < listKhoa.Count; i++)
            {
                if (listKhoa[i].MaKhoa == khoa.MaKhoa)
                {
                    listKhoa[i].TenKhoa = khoa.TenKhoa;
                    break;
                }
            }
        }
        public void DeleteKhoa(string maKhoa)
        {
            listKhoa.RemoveAll(k => k.MaKhoa == maKhoa);
        }
    }
}
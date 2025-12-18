using System.Collections.Generic;
using System.Linq;
using MyThi_490.Model;

namespace MyThi_490.DAL
{
    public class MonHocDAL
    {
        private static List<MonHoc> listMonHoc;

        public MonHocDAL()
        {
            if (listMonHoc == null)
            {
                listMonHoc = new List<MonHoc>();
         
                listMonHoc.Add(new MonHoc("CMP178", "Lập trình Windows", 4));
                listMonHoc.Add(new MonHoc("CMP179", "Cấu trúc dữ liệu", 3));
                listMonHoc.Add(new MonHoc("ENG101", "Tiếng Anh 1", 2));
            }
        }

        public List<MonHoc> GetAll() => listMonHoc;

        public bool Add(MonHoc mh)
        {
            if (listMonHoc.Any(x => x.MaMon == mh.MaMon)) return false;
            listMonHoc.Add(mh);
            return true;
        }

        public bool Update(MonHoc mhMoi)
        {
            var mh = listMonHoc.FirstOrDefault(x => x.MaMon == mhMoi.MaMon);
            if (mh != null)
            {
                mh.TenMon = mhMoi.TenMon;
                mh.SoTinChi = mhMoi.SoTinChi;
                return true;
            }
            return false;
        }

        public bool Delete(string maMon)
        {
            var mh = listMonHoc.FirstOrDefault(x => x.MaMon == maMon);
            if (mh != null)
            {
                listMonHoc.Remove(mh);
                return true;
            }
            return false;
        }
    }
}
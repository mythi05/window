using System.Collections.Generic;
using System.Linq;
using MyThi_490.Model;

namespace MyThi_490.DAL
{
    public class LopDAL
    {
        private static List<Lop> listLop;

        public LopDAL()
        {
            if (listLop == null)
            {
                listLop = new List<Lop>();
             
                listLop.Add(new Lop("20DTH1", "Tin học 1 K20", "CNTT"));
                listLop.Add(new Lop("20DTH2", "Tin học 2 K20", "CNTT"));
                listLop.Add(new Lop("21KT1", "Kế toán 1 K21", "KT"));
            }
        }

        public List<Lop> GetAll() => listLop;

        public bool Add(Lop lop)
        {
            if (listLop.Any(x => x.MaLop == lop.MaLop)) return false;
            listLop.Add(lop);
            return true;
        }

        public bool Update(Lop lopMoi)
        {
            var lop = listLop.FirstOrDefault(x => x.MaLop == lopMoi.MaLop);
            if (lop != null)
            {
                lop.TenLop = lopMoi.TenLop;
                lop.MaKhoa = lopMoi.MaKhoa;
                return true;
            }
            return false;
        }

        public bool Delete(string maLop)
        {
            var lop = listLop.FirstOrDefault(x => x.MaLop == maLop);
            if (lop != null)
            {
                listLop.Remove(lop);
                return true;
            }
            return false;
        }
    }
}
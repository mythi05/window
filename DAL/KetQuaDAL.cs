using System.Collections.Generic;
using System.Linq;
using MyThi_490.Model;

namespace MyThi_490.DAL
{
    public class KetQuaDAL
    {
        private static List<KetQua> listKetQua;

        public KetQuaDAL()
        {
            if (listKetQua == null)
            {
                listKetQua = new List<KetQua>();

                listKetQua.Add(new KetQua("SV001", "CMP178", 8.5f));
                listKetQua.Add(new KetQua("SV001", "ENG101", -1)); // -1 nghĩa là chưa có điểm
                listKetQua.Add(new KetQua("SV002", "CMP178", 9.0f));
            }
        }

        public List<KetQua> GetAll() => listKetQua;


     
        public bool CapNhatDiem(string masv, string mamon, float diemMoi)
        {
            var kq = listKetQua.FirstOrDefault(x => x.MaSV == masv && x.MaMon == mamon);
            if (kq != null)
            {
                kq.DiemSo = diemMoi;
                return true;
            }
            return false;
        }

       
    }
}
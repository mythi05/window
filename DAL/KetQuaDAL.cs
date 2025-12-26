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
                listKetQua = new List<KetQua>
                {
                    new KetQua("SV001", "CMP178", 8.5f),
                    new KetQua("SV001", "ENG101", -1),
                    new KetQua("SV002", "CMP178", 9.0f)
                };
            }
        }

        public List<KetQua> GetAll() => listKetQua;

        public bool CapNhatDiem(string maSV, string maMon, float diemMoi)
        {
            var kq = listKetQua.FirstOrDefault(
                x => x.MaSV == maSV && x.MaMon == maMon);

            if (kq != null)
            {
                kq.DiemSo = diemMoi;
                return true;
            }
            return false;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using MyThi_490.Model;

namespace MyThi_490.DAL
{
    public class CoVanDAL
    {
        private static List<CoVan> listCoVan;

        public CoVanDAL()
        {
            if (listCoVan == null)
            {
                listCoVan = new List<CoVan>();
                // Dữ liệu mẫu
                listCoVan.Add(new CoVan("CV001", "Nguyễn Thị C", "CNTT"));
                listCoVan.Add(new CoVan("CV002", "Lê Văn D", "KT"));
                listCoVan.Add(new CoVan("CV003", "Phạm Văn E", "QTKD"));
            }
        }

        public List<CoVan> GetAll() => listCoVan;

        public bool Add(CoVan cv)
        {
            if (listCoVan.Any(x => x.MaCV == cv.MaCV)) return false;
            listCoVan.Add(cv);
            return true;
        }

        public bool Update(CoVan cvMoi)
        {
            var cv = listCoVan.FirstOrDefault(x => x.MaCV == cvMoi.MaCV);
            if (cv != null)
            {
                cv.TenCV = cvMoi.TenCV;
                cv.Khoa = cvMoi.Khoa;
                return true;
            }
            return false;
        }

        public bool Delete(string ma)
        {
            var cv = listCoVan.FirstOrDefault(x => x.MaCV == ma);
            if (cv != null)
            {
                listCoVan.Remove(cv);
                return true;
            }
            return false;
        }
    }
}
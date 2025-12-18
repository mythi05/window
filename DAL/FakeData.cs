using MyThi_490.Model;
using MyThi_490.Model.Thitracnghiem;
using System.Collections.Generic;

namespace MyThi_490.DAL
{
    public static class FakeData
    {
        public static List<CauHoi> GetCauHoi()
        {
            return new List<CauHoi>()
            {
                new CauHoi {
                    NoiDung = "1 + 1 bằng bao nhiêu?",
                    A = "1", B = "2", C = "3", D = "4",
                    DapAnDung = "B"
                },
                new CauHoi {
                    NoiDung = "Thủ đô Việt Nam là?",
                    A = "Huế", B = "HCM", C = "Hà Nội", D = "Đà Nẵng",
                    DapAnDung = "C"
                }
            };
        }
    }
}

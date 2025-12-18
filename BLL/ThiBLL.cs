using MyThi_490.DAL;

using MyThi_490.Model.Thitracnghiem;
using System;
using System.Collections.Generic;

namespace MyThi_490.BLL
{
    public class ThiBLL
    {
        /// <summary>
        /// Lấy danh sách câu hỏi từ lớp dữ liệu
        /// </summary>
        public List<CauHoi> LayDanhSachCauHoi()
        {
            try
            {
                // Đảm bảo lớp FakeData trong DAL có phương thức tĩnh GetCauHoi()
                return FakeData.GetCauHoi();
            }
            catch (Exception)
            {
                return new List<CauHoi>(); // Trả về list rỗng nếu có lỗi để tránh crash
            }
        }

        /// <summary>
        /// Hàm chấm điểm bài thi
        /// </summary>
        public KetQua ChamDiem(List<CauHoi> ds)
        {
            // 1. Kiểm tra nếu danh sách null hoặc không có câu hỏi để tránh lỗi chia cho 0
            if (ds == null || ds.Count == 0)
            {
                return new KetQua { TongCau = 0, SoCauDung = 0, Diem = 0 };
            }

            int dung = 0;
            foreach (var c in ds)
            {
                // So sánh đáp án đã chọn và đáp án đúng (không phân biệt hoa thường)
                if (!string.IsNullOrEmpty(c.DaChon) &&
                    c.DaChon.Trim().ToUpper() == c.DapAnDung.Trim().ToUpper())
                {
                    dung++;
                }
            }

            // 2. Tính điểm (Ép kiểu double để ra số thập phân chính xác)
            double diem = (double)dung * 10.0 / ds.Count;

            // Làm tròn điểm đến 1 chữ số thập phân (ví dụ: 6.666 -> 6.7)
            diem = Math.Round(diem, 1);

            return new KetQua
            {
                TongCau = ds.Count,
                SoCauDung = dung,
                Diem = diem // Đảm bảo lớp Model KetQua có thuộc tính Diem (kiểu double/float)
            };
        }
    }
}
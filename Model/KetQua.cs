namespace MyThi_490.Model
{
    public class KetQua
    {
        public string MaSV { get; set; }
        public string MaMon { get; set; }
        public float DiemSo { get; set; } 

        public KetQua() { }

        public KetQua(string masv, string mamon, float diem)
        {
            this.MaSV = masv;
            this.MaMon = mamon;
            this.DiemSo = diem;
        }
    }
}
namespace MyThi_490.Model 
{
    public class Khoa
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        // Hàm tạo để nhập nhanh dữ liệu giả
        public Khoa(string ma, string ten)
        {
            this.MaKhoa = ma;
            this.TenKhoa = ten;
        }
    }
}
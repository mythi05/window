namespace MyThi_490.Model
{
    public class Lop
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string MaKhoa { get; set; } 

        public Lop() { }

        public Lop(string ma, string ten, string makhoa)
        {
            this.MaLop = ma;
            this.TenLop = ten;
            this.MaKhoa = makhoa;
        }
    }
}
namespace MyThi_490.Model
{
    public class MonHoc
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public int SoTinChi { get; set; }

        public MonHoc() { }

        public MonHoc(string ma, string ten, int tinchi)
        {
            this.MaMon = ma;
            this.TenMon = ten;
            this.SoTinChi = tinchi;
        }
    }
}
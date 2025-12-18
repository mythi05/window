namespace MyThi_490.Model
{
    public class CoVan
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public string Khoa { get; set; }

        public CoVan() { }

        public CoVan(string ma, string ten, string khoa)
        {
            this.MaCV = ma;
            this.TenCV = ten;
            this.Khoa = khoa;
        }
    }
}
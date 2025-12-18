using System;
using System.Windows.Forms;

namespace MyThi_490.GUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // Đăng ký sự kiện click cho các nút
            btnOpenSV.Click += (s, e) => OpenForm(new Quanlysinhvien());
            btnOpenLop.Click += (s, e) => OpenForm(new Quanlylop());
            btnOpenDiem.Click += (s, e) => OpenForm(new Quanlydiem());
        }

        private void OpenForm(Form childForm)
        {
            // Hiển thị form con
            childForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Ở đây bạn có thể gọi BLL để lấy số lượng thực tế từ Database
            // Ví dụ: lblSVCount.Text = svBLL.CountTotal().ToString();

            // Hiện tại mình gán mặc định để giao diện đẹp
            lblSVCount.Text = "1,420";
            lblLopCount.Text = "32";
            lblKhoaCount.Text = "6";
        }
    }
}
using System;
using System.Windows.Forms;
using MyThi_490.BLL; // Đảm bảo bạn có lớp nghiệp vụ tài khoản

namespace MyThi_490.GUI
{
    public partial class Change : Form
    {
        // Giả sử bạn dùng TaiKhoanBLL để xử lý đăng nhập/đổi mật khẩu
        // TaiKhoanBLL bll = new TaiKhoanBLL(); 

        public Change()
        {
            InitializeComponent();

            // Gán sự kiện
            this.btndoi.Click += Btndoi_Click;
            this.btnExit.Click += BtnExit_Click;
        }

        private void Btndoi_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string confirmPass = txtConfirmPass.Text;

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(oldPass) || string.IsNullOrEmpty(newPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // 2. Kiểm tra mật khẩu mới và xác nhận có khớp không
            if (newPass != confirmPass)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp!");
                return;
            }

            // 3. Gọi BLL xử lý (Đoạn này bạn thay bằng hàm thực tế trong dự án của bạn)
            /*
            string username = "admin"; // Lấy từ phiên đăng nhập hoặc biến toàn cục
            string ketQua = bll.ChangePassword(username, oldPass, newPass);
            MessageBox.Show(ketQua);
            if(ketQua.Contains("thành công")) this.Close();
            */

            MessageBox.Show("Hệ thống: Đã ghi nhận yêu cầu đổi mật khẩu.");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Có thể dùng để lấy thông tin user hiện tại nếu cần
        }
    }
}
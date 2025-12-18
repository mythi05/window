using System;
using System.Windows.Forms;

using MyThi_490.Model.Thitracnghiem;
namespace MyThi_490.GUI
{
    public partial class FrmKetQua : Form
    {
        // Constructor nhận đối tượng kết quả
        public FrmKetQua(KetQua kq)
        {
            InitializeComponent();

            // Hiển thị dữ liệu lên các Label đã đặt tên trong Designer
            lblValTong.Text = kq.TongCau.ToString();
            lblValDung.Text = kq.SoCauDung.ToString();
            lblValDiem.Text = kq.Diem.ToString("0.0");

            // Nếu trong model KetQua có thông tin SV, bạn có thể đổ vào đây
            // lblValMaSV.Text = kq.MaSV;
            // lblValHoTen.Text = kq.HoTen;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            // Thay vì Exit toàn bộ app, thường ta sẽ đóng form kết quả để về Dashboard
            this.Close();
            // Nếu muốn thoát hẳn thì dùng: Application.Exit();
        }
    }
}
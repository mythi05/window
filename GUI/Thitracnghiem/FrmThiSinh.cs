using System;
using System.Windows.Forms;
using MyThi_490.Model;
using MyThi_490.Model.Thitracnghiem;

namespace MyThi_490.GUI
{
    public partial class FrmThiSinh : Form
    {
        public FrmThiSinh()
        {
            InitializeComponent();
            this.Load += (s, e) => {
                if (cbGioiTinh.Items.Count > 0) cbGioiTinh.SelectedIndex = 0;
                if (cbKyThi.Items.Count > 0) cbKyThi.SelectedIndex = 0;
            };
            btnKetThuc.Click += (s, e) => this.Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập liệu cơ bản
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SV và Họ tên thí sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo đối tượng thí sinh từ giao diện
            // (Đảm bảo Class ThiSinh có các thuộc tính MaSV, HoTen,...)
            ThiSinh ts = new ThiSinh
            {
                Ma = txtMaSV.Text.Trim(),
                Ten = txtHoTen.Text.Trim(),
                GioiTinh = cbGioiTinh.Text,
                NgaySinh = txtNgaySinh.Text.Trim(),
                NoiSinh = txtNoiSinh.Text.Trim()
            };

            // Chuyển sang form Làm bài
            FrmLamBai frm = new FrmLamBai(ts);
            frm.Show();

            this.Hide(); // Ẩn form thông tin thí sinh
        }
    }
}
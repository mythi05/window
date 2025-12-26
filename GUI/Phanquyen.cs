using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MyThi_490.GUI
{
    public partial class Phanquyen : Form
    {
        public Phanquyen()
        {
            InitializeComponent();

            // Gán sự kiện
            btnSave.Click += btnSave_Click;
            btnReset.Click += btnReset_Click;
        }

        // =========================
        // LƯU PHÂN QUYỀN (LOCAL)
        // =========================
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (cboRole.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn vai trò!",
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy danh sách quyền
            List<string> quyen = new List<string>();

            if (chkSinhVien.Checked) quyen.Add("Quản lý Sinh viên");
            if (chkLop.Checked) quyen.Add("Quản lý Lớp");
            if (chkKhoa.Checked) quyen.Add("Quản lý Khoa");
            if (chkMonHoc.Checked) quyen.Add("Quản lý Môn học");
            if (chkDiem.Checked) quyen.Add("Quản lý Điểm");

            if (quyen.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 quyền!",
                    "Chưa chọn quyền",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // 3. Hiển thị kết quả (giả lập lưu)
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tài khoản: {txtUsername.Text}");
            sb.AppendLine($"Vai trò: {cboRole.Text}");
            sb.AppendLine("Quyền được cấp:");

            foreach (var q in quyen)
                sb.AppendLine(" - " + q);

            MessageBox.Show(sb.ToString(),
                "Lưu phân quyền thành công",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // =========================
        // LÀM MỚI FORM
        // =========================
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            cboRole.SelectedIndex = -1;

            chkSinhVien.Checked = false;
            chkLop.Checked = false;
            chkKhoa.Checked = false;
            chkMonHoc.Checked = false;
            chkDiem.Checked = false;
        }
    }
}

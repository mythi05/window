using MyThi_490.GUI;

using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyThi_490
{
    public partial class MainForm : Form
    {
        // Các biến để lưu trạng thái giao diện
        private Button currentButton;
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Full màn hình trừ thanh taskbar
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            OpenChildForm(new Dashboard(), btnDashboard);

        }


        // --- HÀM 1: Hiệu ứng nút bấm (Highlight nút đang chọn) ---
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(); // Trả màu nút cũ về bình thường

                    // Chỉnh màu nút mới
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(73, 85, 115); // Màu sáng hơn màu nền
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

                    // Cập nhật tiêu đề trên thanh TopBar
                    lblTitle.Text = currentButton.Text.ToUpper();
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76); // Màu gốc Sidebar
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
                }
            }
        }

        // --- HÀM 2: Mở Form con nhúng vào Panel (QUAN TRỌNG NHẤT) ---
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender); // Gọi hiệu ứng nút

            activeForm = childForm;
            childForm.TopLevel = false; // Biến Form thành Control thường
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền
            childForm.Dock = DockStyle.Fill; // Lấp đầy

            this.panelDesktop.Controls.Add(childForm); // Thêm vào Panel
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // --- CÁC SỰ KIỆN CLICK MENU ---
        // Lưu ý: Truyền 'sender' vào hàm OpenChildForm để nó biết nút nào đang bấm



        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                this.Close();
                Application.Restart();
            }
        }


        private void panelLogo_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "TRANG CHỦ";
            currentButton = null;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard(), sender);
        }

        private void bntsv_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlysinhvien(), sender);
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlylop(), sender);
        }

        private void btnCoVan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlycovan(), sender);
        }
        private void btnKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlykhoa(), sender);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlymonhoc(), sender);
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
                OpenChildForm(new Quanlydiem(), sender);
        }

        private void change_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Change(), sender);
        }

        private void bntKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Quanlykhoa(), sender);
        }

        private void phanquyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Phanquyen(), sender);
        }

        private void btnVaothi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThiSinh(), sender);
        }
    }
}
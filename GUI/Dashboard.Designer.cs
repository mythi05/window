namespace MyThi_490.GUI
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSV = new System.Windows.Forms.Panel();
            this.lblSVCount = new System.Windows.Forms.Label();
            this.lblSVTitle = new System.Windows.Forms.Label();
            this.panelLop = new System.Windows.Forms.Panel();
            this.lblLopCount = new System.Windows.Forms.Label();
            this.lblLopTitle = new System.Windows.Forms.Label();
            this.panelKhoa = new System.Windows.Forms.Panel();
            this.lblKhoaCount = new System.Windows.Forms.Label();
            this.lblKhoaTitle = new System.Windows.Forms.Label();
            this.lblQuickAccess = new System.Windows.Forms.Label();
            this.btnOpenSV = new System.Windows.Forms.Button();
            this.btnOpenLop = new System.Windows.Forms.Button();
            this.btnOpenDiem = new System.Windows.Forms.Button();
            this.panelSV.SuspendLayout();
            this.panelLop.SuspendLayout();
            this.panelKhoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSV
            // 
            this.panelSV.BackColor = System.Drawing.Color.White;
            this.panelSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSV.Controls.Add(this.lblSVCount);
            this.panelSV.Controls.Add(this.lblSVTitle);
            this.panelSV.Location = new System.Drawing.Point(50, 77);
            this.panelSV.Name = "panelSV";
            this.panelSV.Size = new System.Drawing.Size(280, 173);
            this.panelSV.TabIndex = 6;
            // 
            // lblSVCount
            // 
            this.lblSVCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSVCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSVCount.Location = new System.Drawing.Point(0, 45);
            this.lblSVCount.Name = "lblSVCount";
            this.lblSVCount.Size = new System.Drawing.Size(280, 60);
            this.lblSVCount.TabIndex = 0;
            this.lblSVCount.Text = "1,250";
            this.lblSVCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSVTitle
            // 
            this.lblSVTitle.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblSVTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSVTitle.ForeColor = System.Drawing.Color.White;
            this.lblSVTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSVTitle.Name = "lblSVTitle";
            this.lblSVTitle.Size = new System.Drawing.Size(278, 23);
            this.lblSVTitle.TabIndex = 1;
            this.lblSVTitle.Text = "TỔNG SINH VIÊN";
            this.lblSVTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLop
            // 
            this.panelLop.BackColor = System.Drawing.Color.White;
            this.panelLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLop.Controls.Add(this.lblLopCount);
            this.panelLop.Controls.Add(this.lblLopTitle);
            this.panelLop.Location = new System.Drawing.Point(360, 78);
            this.panelLop.Name = "panelLop";
            this.panelLop.Size = new System.Drawing.Size(280, 172);
            this.panelLop.TabIndex = 5;
            // 
            // lblLopCount
            // 
            this.lblLopCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblLopCount.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblLopCount.Location = new System.Drawing.Point(0, 45);
            this.lblLopCount.Name = "lblLopCount";
            this.lblLopCount.Size = new System.Drawing.Size(280, 60);
            this.lblLopCount.TabIndex = 0;
            this.lblLopCount.Text = "45";
            this.lblLopCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLopTitle
            // 
            this.lblLopTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.lblLopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLopTitle.ForeColor = System.Drawing.Color.White;
            this.lblLopTitle.Location = new System.Drawing.Point(0, 0);
            this.lblLopTitle.Name = "lblLopTitle";
            this.lblLopTitle.Size = new System.Drawing.Size(278, 23);
            this.lblLopTitle.TabIndex = 1;
            this.lblLopTitle.Text = "TỔNG LỚP HỌC";
            this.lblLopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelKhoa
            // 
            this.panelKhoa.BackColor = System.Drawing.Color.White;
            this.panelKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKhoa.Controls.Add(this.lblKhoaCount);
            this.panelKhoa.Controls.Add(this.lblKhoaTitle);
            this.panelKhoa.Location = new System.Drawing.Point(670, 78);
            this.panelKhoa.Name = "panelKhoa";
            this.panelKhoa.Size = new System.Drawing.Size(280, 172);
            this.panelKhoa.TabIndex = 4;
            // 
            // lblKhoaCount
            // 
            this.lblKhoaCount.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblKhoaCount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblKhoaCount.Location = new System.Drawing.Point(0, 45);
            this.lblKhoaCount.Name = "lblKhoaCount";
            this.lblKhoaCount.Size = new System.Drawing.Size(280, 60);
            this.lblKhoaCount.TabIndex = 0;
            this.lblKhoaCount.Text = "8";
            this.lblKhoaCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKhoaTitle
            // 
            this.lblKhoaTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.lblKhoaTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKhoaTitle.ForeColor = System.Drawing.Color.White;
            this.lblKhoaTitle.Location = new System.Drawing.Point(0, 0);
            this.lblKhoaTitle.Name = "lblKhoaTitle";
            this.lblKhoaTitle.Size = new System.Drawing.Size(278, 23);
            this.lblKhoaTitle.TabIndex = 1;
            this.lblKhoaTitle.Text = "TỔNG KHOA";
            this.lblKhoaTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuickAccess
            // 
            this.lblQuickAccess.AutoSize = true;
            this.lblQuickAccess.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuickAccess.Location = new System.Drawing.Point(50, 300);
            this.lblQuickAccess.Name = "lblQuickAccess";
            this.lblQuickAccess.Size = new System.Drawing.Size(264, 38);
            this.lblQuickAccess.TabIndex = 3;
            this.lblQuickAccess.Text = "TRUY CẬP NHANH";
            // 
            // btnOpenSV
            // 
            this.btnOpenSV.BackColor = System.Drawing.Color.Teal;
            this.btnOpenSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenSV.ForeColor = System.Drawing.Color.White;
            this.btnOpenSV.Location = new System.Drawing.Point(50, 350);
            this.btnOpenSV.Name = "btnOpenSV";
            this.btnOpenSV.Size = new System.Drawing.Size(200, 60);
            this.btnOpenSV.TabIndex = 2;
            this.btnOpenSV.Text = "Quản lý Sinh Viên";
            this.btnOpenSV.UseVisualStyleBackColor = false;
            // 
            // btnOpenLop
            // 
            this.btnOpenLop.BackColor = System.Drawing.Color.Teal;
            this.btnOpenLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLop.ForeColor = System.Drawing.Color.White;
            this.btnOpenLop.Location = new System.Drawing.Point(270, 350);
            this.btnOpenLop.Name = "btnOpenLop";
            this.btnOpenLop.Size = new System.Drawing.Size(200, 60);
            this.btnOpenLop.TabIndex = 1;
            this.btnOpenLop.Text = "Quản lý Lớp";
            this.btnOpenLop.UseVisualStyleBackColor = false;
            // 
            // btnOpenDiem
            // 
            this.btnOpenDiem.BackColor = System.Drawing.Color.Teal;
            this.btnOpenDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDiem.ForeColor = System.Drawing.Color.White;
            this.btnOpenDiem.Location = new System.Drawing.Point(490, 350);
            this.btnOpenDiem.Name = "btnOpenDiem";
            this.btnOpenDiem.Size = new System.Drawing.Size(200, 60);
            this.btnOpenDiem.TabIndex = 0;
            this.btnOpenDiem.Text = "Quản lý Điểm";
            this.btnOpenDiem.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnOpenDiem);
            this.Controls.Add(this.btnOpenLop);
            this.Controls.Add(this.btnOpenSV);
            this.Controls.Add(this.lblQuickAccess);
            this.Controls.Add(this.panelKhoa);
            this.Controls.Add(this.panelLop);
            this.Controls.Add(this.panelSV);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ - Quản Lý Đào Tạo";
            this.panelSV.ResumeLayout(false);
            this.panelLop.ResumeLayout(false);
            this.panelKhoa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSV;
        private System.Windows.Forms.Label lblSVCount;
        private System.Windows.Forms.Label lblSVTitle;
        private System.Windows.Forms.Panel panelLop;
        private System.Windows.Forms.Label lblLopCount;
        private System.Windows.Forms.Label lblLopTitle;
        private System.Windows.Forms.Panel panelKhoa;
        private System.Windows.Forms.Label lblKhoaCount;
        private System.Windows.Forms.Label lblKhoaTitle;
        private System.Windows.Forms.Label lblQuickAccess;
        private System.Windows.Forms.Button btnOpenSV;
        private System.Windows.Forms.Button btnOpenLop;
        private System.Windows.Forms.Button btnOpenDiem;
    }
}
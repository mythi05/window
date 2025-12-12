namespace MyThi_490
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuQLSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuQLKhoa;
        private System.Windows.Forms.ToolStripMenuItem menuQLLop;
        private System.Windows.Forms.ToolStripMenuItem menuQLCoVan;
        private System.Windows.Forms.ToolStripMenuItem menuQLMonHoc;
        private System.Windows.Forms.ToolStripMenuItem menuTaiKhoan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLKhoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLCoVan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQuanLy,
            this.menuTaiKhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 33);
            this.menuStrip1.TabIndex = 0;
            // 
            // menuQuanLy
            // 
            this.menuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLSinhVien,
            this.menuQLKhoa,
            this.menuQLLop,
            this.menuQLCoVan,
            this.menuQLMonHoc});
            this.menuQuanLy.Name = "menuQuanLy";
            this.menuQuanLy.Size = new System.Drawing.Size(89, 29);
            this.menuQuanLy.Text = "Quản lý";
            // 
            // menuQLSinhVien
            // 
            this.menuQLSinhVien.Name = "menuQLSinhVien";
            this.menuQLSinhVien.Size = new System.Drawing.Size(297, 34);
            this.menuQLSinhVien.Text = "Quản lý sinh viên";
            this.menuQLSinhVien.Click += new System.EventHandler(this.menuQLSinhVien_Click);
            // 
            // menuQLKhoa
            // 
            this.menuQLKhoa.Name = "menuQLKhoa";
            this.menuQLKhoa.Size = new System.Drawing.Size(297, 34);
            this.menuQLKhoa.Text = "Quản lý khoa";
            this.menuQLKhoa.Click += new System.EventHandler(this.menuQLKhoa_Click);
            // 
            // menuQLLop
            // 
            this.menuQLLop.Name = "menuQLLop";
            this.menuQLLop.Size = new System.Drawing.Size(297, 34);
            this.menuQLLop.Text = "Quản lý lớp";
            this.menuQLLop.Click += new System.EventHandler(this.menuQLLop_Click);
            // 
            // menuQLCoVan
            // 
            this.menuQLCoVan.Name = "menuQLCoVan";
            this.menuQLCoVan.Size = new System.Drawing.Size(297, 34);
            this.menuQLCoVan.Text = "Quản lý cố vấn học tập";
            this.menuQLCoVan.Click += new System.EventHandler(this.menuQLCoVan_Click);
            // 
            // menuQLMonHoc
            // 
            this.menuQLMonHoc.Name = "menuQLMonHoc";
            this.menuQLMonHoc.Size = new System.Drawing.Size(297, 34);
            this.menuQLMonHoc.Text = "Quản lý môn học";
            this.menuQLMonHoc.Click += new System.EventHandler(this.menuQLMonHoc_Click);
            // 
            // menuTaiKhoan
            // 
            this.menuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.menuTaiKhoan.Name = "menuTaiKhoan";
            this.menuTaiKhoan.Size = new System.Drawing.Size(102, 29);
            this.menuTaiKhoan.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}

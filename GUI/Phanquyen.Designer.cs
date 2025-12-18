

// =============================
// FILE: PhanQuyen.Designer.cs
// =============================
namespace MyThi_490.GUI
{
    partial class Phanquyen
    {
        private System.ComponentModel.IContainer components = null;

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
            this.groupUser = new System.Windows.Forms.GroupBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupPermission = new System.Windows.Forms.GroupBox();
            this.chkDiem = new System.Windows.Forms.CheckBox();
            this.chkMonHoc = new System.Windows.Forms.CheckBox();
            this.chkKhoa = new System.Windows.Forms.CheckBox();
            this.chkLop = new System.Windows.Forms.CheckBox();
            this.chkSinhVien = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupUser.SuspendLayout();
            this.groupPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupUser
            // 
            this.groupUser.Controls.Add(this.cboRole);
            this.groupUser.Controls.Add(this.lblRole);
            this.groupUser.Controls.Add(this.txtUsername);
            this.groupUser.Controls.Add(this.lblUsername);
            this.groupUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupUser.Location = new System.Drawing.Point(22, 71);
            this.groupUser.Name = "groupUser";
            this.groupUser.Size = new System.Drawing.Size(380, 200);
            this.groupUser.TabIndex = 1;
            this.groupUser.TabStop = false;
            this.groupUser.Text = "Thông tin người dùng";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Giáo vụ",
            "Cố vấn",
            "Giảng viên"});
            this.cboRole.Location = new System.Drawing.Point(140, 120);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(200, 36);
            this.cboRole.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.Location = new System.Drawing.Point(20, 125);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(73, 28);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Vai trò:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(140, 55);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 34);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.Location = new System.Drawing.Point(20, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tài khoản:";
            // 
            // groupPermission
            // 
            this.groupPermission.Controls.Add(this.chkDiem);
            this.groupPermission.Controls.Add(this.chkMonHoc);
            this.groupPermission.Controls.Add(this.chkKhoa);
            this.groupPermission.Controls.Add(this.chkLop);
            this.groupPermission.Controls.Add(this.chkSinhVien);
            this.groupPermission.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupPermission.Location = new System.Drawing.Point(553, 71);
            this.groupPermission.Name = "groupPermission";
            this.groupPermission.Size = new System.Drawing.Size(380, 200);
            this.groupPermission.TabIndex = 2;
            this.groupPermission.TabStop = false;
            this.groupPermission.Text = "Quyền truy cập";
            // 
            // chkDiem
            // 
            this.chkDiem.AutoSize = true;
            this.chkDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDiem.Location = new System.Drawing.Point(30, 150);
            this.chkDiem.Name = "chkDiem";
            this.chkDiem.Size = new System.Drawing.Size(156, 32);
            this.chkDiem.TabIndex = 4;
            this.chkDiem.Text = "Quản lý Điểm";
            this.chkDiem.UseVisualStyleBackColor = true;
            // 
            // chkMonHoc
            // 
            this.chkMonHoc.AutoSize = true;
            this.chkMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkMonHoc.Location = new System.Drawing.Point(30, 120);
            this.chkMonHoc.Name = "chkMonHoc";
            this.chkMonHoc.Size = new System.Drawing.Size(188, 32);
            this.chkMonHoc.TabIndex = 3;
            this.chkMonHoc.Text = "Quản lý Môn học";
            this.chkMonHoc.UseVisualStyleBackColor = true;
            // 
            // chkKhoa
            // 
            this.chkKhoa.AutoSize = true;
            this.chkKhoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkKhoa.Location = new System.Drawing.Point(30, 90);
            this.chkKhoa.Name = "chkKhoa";
            this.chkKhoa.Size = new System.Drawing.Size(155, 32);
            this.chkKhoa.TabIndex = 2;
            this.chkKhoa.Text = "Quản lý Khoa";
            this.chkKhoa.UseVisualStyleBackColor = true;
            // 
            // chkLop
            // 
            this.chkLop.AutoSize = true;
            this.chkLop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkLop.Location = new System.Drawing.Point(30, 60);
            this.chkLop.Name = "chkLop";
            this.chkLop.Size = new System.Drawing.Size(143, 32);
            this.chkLop.TabIndex = 1;
            this.chkLop.Text = "Quản lý Lớp";
            this.chkLop.UseVisualStyleBackColor = true;
            // 
            // chkSinhVien
            // 
            this.chkSinhVien.AutoSize = true;
            this.chkSinhVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkSinhVien.Location = new System.Drawing.Point(30, 30);
            this.chkSinhVien.Name = "chkSinhVien";
            this.chkSinhVien.Size = new System.Drawing.Size(189, 32);
            this.chkSinhVien.TabIndex = 0;
            this.chkSinhVien.Text = "Quản lý Sinh viên";
            this.chkSinhVien.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(230, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu phân quyền";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReset.Location = new System.Drawing.Point(482, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Phanquyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 727);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupPermission);
            this.Controls.Add(this.groupUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Phanquyen";
            this.Text = "PhanQuyen";
            this.groupUser.ResumeLayout(false);
            this.groupUser.PerformLayout();
            this.groupPermission.ResumeLayout(false);
            this.groupPermission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupUser;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupPermission;
        private System.Windows.Forms.CheckBox chkDiem;
        private System.Windows.Forms.CheckBox chkMonHoc;
        private System.Windows.Forms.CheckBox chkKhoa;
        private System.Windows.Forms.CheckBox chkLop;
        private System.Windows.Forms.CheckBox chkSinhVien;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
    }
}

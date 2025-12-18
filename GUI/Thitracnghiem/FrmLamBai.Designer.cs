namespace MyThi_490.GUI
{
    partial class FrmLamBai
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblThongTin = new System.Windows.Forms.Label();
            this.grpCauHoi = new System.Windows.Forms.GroupBox();
            this.lblSTT = new System.Windows.Forms.Label();
            this.lblNoiDungCauHoi = new System.Windows.Forms.Label();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnNopBai = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.grpCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Teal;
            this.panelHeader.Controls.Add(this.lblThongTin);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // lblThongTin
            // 
            this.lblThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThongTin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblThongTin.ForeColor = System.Drawing.Color.White;
            this.lblThongTin.Location = new System.Drawing.Point(0, 0);
            this.lblThongTin.Name = "lblThongTin";
            this.lblThongTin.Size = new System.Drawing.Size(900, 60);
            this.lblThongTin.TabIndex = 0;
            this.lblThongTin.Text = "Mã SV: 0001 | Tên: Nguyễn Văn A | Ngày sinh: 01/01/1996";
            this.lblThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCauHoi
            // 
            this.grpCauHoi.Controls.Add(this.lblSTT);
            this.grpCauHoi.Controls.Add(this.lblNoiDungCauHoi);
            this.grpCauHoi.Controls.Add(this.rdoA);
            this.grpCauHoi.Controls.Add(this.rdoB);
            this.grpCauHoi.Controls.Add(this.rdoC);
            this.grpCauHoi.Controls.Add(this.rdoD);
            this.grpCauHoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpCauHoi.Location = new System.Drawing.Point(30, 80);
            this.grpCauHoi.Name = "grpCauHoi";
            this.grpCauHoi.Size = new System.Drawing.Size(840, 320);
            this.grpCauHoi.TabIndex = 1;
            this.grpCauHoi.TabStop = false;
            // 
            // lblSTT
            // 
            this.lblSTT.AutoSize = true;
            this.lblSTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSTT.ForeColor = System.Drawing.Color.Teal;
            this.lblSTT.Location = new System.Drawing.Point(20, 25);
            this.lblSTT.Name = "lblSTT";
            this.lblSTT.Size = new System.Drawing.Size(85, 32);
            this.lblSTT.TabIndex = 0;
            this.lblSTT.Text = "Câu 1:";
            // 
            // lblNoiDungCauHoi
            // 
            this.lblNoiDungCauHoi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNoiDungCauHoi.Location = new System.Drawing.Point(20, 65);
            this.lblNoiDungCauHoi.Name = "lblNoiDungCauHoi";
            this.lblNoiDungCauHoi.Size = new System.Drawing.Size(800, 70);
            this.lblNoiDungCauHoi.TabIndex = 1;
            this.lblNoiDungCauHoi.Text = "Nội dung câu hỏi sẽ hiển thị ở đây?";
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(40, 150);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(117, 32);
            this.rdoA.TabIndex = 2;
            this.rdoA.Text = "Đáp án A";
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Location = new System.Drawing.Point(40, 190);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(115, 32);
            this.rdoB.TabIndex = 3;
            this.rdoB.Text = "Đáp án B";
            // 
            // rdoC
            // 
            this.rdoC.AutoSize = true;
            this.rdoC.Location = new System.Drawing.Point(40, 230);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(116, 32);
            this.rdoC.TabIndex = 4;
            this.rdoC.Text = "Đáp án C";
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(40, 270);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(118, 32);
            this.rdoD.TabIndex = 5;
            this.rdoD.Text = "Đáp án D";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Gray;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.ForeColor = System.Drawing.Color.White;
            this.btnQuayLai.Location = new System.Drawing.Point(30, 420);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(120, 45);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "<< Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.Location = new System.Drawing.Point(160, 420);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(120, 45);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục >>";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.Color.Crimson;
            this.btnNopBai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNopBai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNopBai.ForeColor = System.Drawing.Color.White;
            this.btnNopBai.Location = new System.Drawing.Point(720, 420);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(150, 45);
            this.btnNopBai.TabIndex = 0;
            this.btnNopBai.Text = "NỘP BÀI";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click_1);
            // 
            // FrmLamBai
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnNopBai);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.grpCauHoi);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLamBai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Thi Trắc Nghiệm";
            this.panelHeader.ResumeLayout(false);
            this.grpCauHoi.ResumeLayout(false);
            this.grpCauHoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.GroupBox grpCauHoi;
        private System.Windows.Forms.Label lblSTT;
        private System.Windows.Forms.Label lblNoiDungCauHoi;
        private System.Windows.Forms.RadioButton rdoA, rdoB, rdoC, rdoD;
        private System.Windows.Forms.Button btnQuayLai, btnTiepTuc, btnNopBai;
    }
}
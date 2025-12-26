namespace MyThi_490.GUI
{
    partial class FrmKetQua
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblValNgaySinh = new System.Windows.Forms.Label();
            this.lblValHoTen = new System.Windows.Forms.Label();
            this.lblValMaSV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lblValDiem = new System.Windows.Forms.Label();
            this.lblValDung = new System.Windows.Forms.Label();
            this.lblValTong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Teal;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(673, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.MintCream;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(673, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "KẾT QUẢ BÀI THI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblValNgaySinh);
            this.grpThongTin.Controls.Add(this.lblValHoTen);
            this.grpThongTin.Controls.Add(this.lblValMaSV);
            this.grpThongTin.Controls.Add(this.label3);
            this.grpThongTin.Controls.Add(this.label2);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.ForeColor = System.Drawing.Color.Teal;
            this.grpThongTin.Location = new System.Drawing.Point(30, 90);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(593, 163);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin thí sinh";
            // 
            // lblValNgaySinh
            // 
            this.lblValNgaySinh.AutoSize = true;
            this.lblValNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblValNgaySinh.Location = new System.Drawing.Point(150, 100);
            this.lblValNgaySinh.Name = "lblValNgaySinh";
            this.lblValNgaySinh.Size = new System.Drawing.Size(126, 28);
            this.lblValNgaySinh.TabIndex = 0;
            this.lblValNgaySinh.Text = "01/01/2000";
            // 
            // lblValHoTen
            // 
            this.lblValHoTen.AutoSize = true;
            this.lblValHoTen.ForeColor = System.Drawing.Color.Black;
            this.lblValHoTen.Location = new System.Drawing.Point(150, 65);
            this.lblValHoTen.Name = "lblValHoTen";
            this.lblValHoTen.Size = new System.Drawing.Size(147, 28);
            this.lblValHoTen.TabIndex = 1;
            this.lblValHoTen.Text = "Nguyễn Văn A";
            // 
            // lblValMaSV
            // 
            this.lblValMaSV.AutoSize = true;
            this.lblValMaSV.ForeColor = System.Drawing.Color.Black;
            this.lblValMaSV.Location = new System.Drawing.Point(150, 30);
            this.lblValMaSV.Name = "lblValMaSV";
            this.lblValMaSV.Size = new System.Drawing.Size(72, 28);
            this.lblValMaSV.TabIndex = 2;
            this.lblValMaSV.Text = "SV001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên SV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã sinh viên:";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lblValDiem);
            this.grpKetQua.Controls.Add(this.lblValDung);
            this.grpKetQua.Controls.Add(this.lblValTong);
            this.grpKetQua.Controls.Add(this.label4);
            this.grpKetQua.Controls.Add(this.label5);
            this.grpKetQua.Controls.Add(this.label6);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpKetQua.ForeColor = System.Drawing.Color.Teal;
            this.grpKetQua.Location = new System.Drawing.Point(30, 250);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(593, 239);
            this.grpKetQua.TabIndex = 2;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả chi tiết";
            // 
            // lblValDiem
            // 
            this.lblValDiem.AutoSize = true;
            this.lblValDiem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblValDiem.ForeColor = System.Drawing.Color.Red;
            this.lblValDiem.Location = new System.Drawing.Point(150, 95);
            this.lblValDiem.Name = "lblValDiem";
            this.lblValDiem.Size = new System.Drawing.Size(80, 54);
            this.lblValDiem.TabIndex = 0;
            this.lblValDiem.Text = "0.0";
            // 
            // lblValDung
            // 
            this.lblValDung.AutoSize = true;
            this.lblValDung.ForeColor = System.Drawing.Color.Black;
            this.lblValDung.Location = new System.Drawing.Point(150, 65);
            this.lblValDung.Name = "lblValDung";
            this.lblValDung.Size = new System.Drawing.Size(24, 28);
            this.lblValDung.TabIndex = 1;
            this.lblValDung.Text = "0";
            // 
            // lblValTong
            // 
            this.lblValTong.AutoSize = true;
            this.lblValTong.ForeColor = System.Drawing.Color.Black;
            this.lblValTong.Location = new System.Drawing.Point(150, 30);
            this.lblValTong.Name = "lblValTong";
            this.lblValTong.Size = new System.Drawing.Size(24, 28);
            this.lblValTong.TabIndex = 2;
            this.lblValTong.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐIỂM SỐ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số câu đúng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng số câu:";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.White;
            this.btnKetThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKetThuc.ForeColor = System.Drawing.Color.Black;
            this.btnKetThuc.Location = new System.Drawing.Point(481, 495);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(180, 45);
            this.btnKetThuc.TabIndex = 3;
            this.btnKetThuc.Text = "KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // FrmKetQua
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 568);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Thi";
            this.panelHeader.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.grpKetQua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label label3, label2, label1;
        private System.Windows.Forms.Label lblValNgaySinh, lblValHoTen, lblValMaSV;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.Label label4, label5, label6;
        private System.Windows.Forms.Label lblValDiem, lblValDung, lblValTong;
        private System.Windows.Forms.Button btnKetThuc;
    }
}
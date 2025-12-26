namespace MyThi_490.GUI
{
    partial class FrmThiSinh
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
            this.grpThiSinh = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.grpKyThi = new System.Windows.Forms.GroupBox();
            this.lblKyThi = new System.Windows.Forms.Label();
            this.cbKyThi = new System.Windows.Forms.ComboBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.grpThiSinh.SuspendLayout();
            this.grpKyThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Teal;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(829, 60);
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
            this.lblTitle.Size = new System.Drawing.Size(829, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chương trình thi trắc nghiệm";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // grpThiSinh
            // 
            this.grpThiSinh.Controls.Add(this.lblMaSV);
            this.grpThiSinh.Controls.Add(this.txtMaSV);
            this.grpThiSinh.Controls.Add(this.lblHoTen);
            this.grpThiSinh.Controls.Add(this.txtHoTen);
            this.grpThiSinh.Controls.Add(this.lblNgaySinh);
            this.grpThiSinh.Controls.Add(this.txtNgaySinh);
            this.grpThiSinh.Controls.Add(this.lblNoiSinh);
            this.grpThiSinh.Controls.Add(this.txtNoiSinh);
            this.grpThiSinh.Controls.Add(this.lblGioiTinh);
            this.grpThiSinh.Controls.Add(this.cbGioiTinh);
            this.grpThiSinh.Controls.Add(this.lblDiaChi);
            this.grpThiSinh.Controls.Add(this.txtDiaChi);
            this.grpThiSinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpThiSinh.Location = new System.Drawing.Point(20, 63);
            this.grpThiSinh.Name = "grpThiSinh";
            this.grpThiSinh.Size = new System.Drawing.Size(778, 287);
            this.grpThiSinh.TabIndex = 3;
            this.grpThiSinh.TabStop = false;
            this.grpThiSinh.Text = "Lý lịch thí sinh";
            // 
            // lblMaSV
            // 
            this.lblMaSV.Location = new System.Drawing.Point(20, 35);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(100, 23);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(120, 32);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(200, 34);
            this.txtMaSV.TabIndex = 1;
            // 
            // lblHoTen
            // 
            this.lblHoTen.Location = new System.Drawing.Point(20, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(100, 31);
            this.lblHoTen.TabIndex = 2;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(120, 72);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 34);
            this.txtHoTen.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 115);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 34);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(120, 112);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(200, 34);
            this.txtNgaySinh.TabIndex = 5;
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.Location = new System.Drawing.Point(20, 155);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(100, 31);
            this.lblNoiSinh.TabIndex = 6;
            this.lblNoiSinh.Text = "Nơi sinh:";
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Location = new System.Drawing.Point(120, 152);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(200, 34);
            this.txtNoiSinh.TabIndex = 7;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.Location = new System.Drawing.Point(20, 189);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(100, 23);
            this.lblGioiTinh.TabIndex = 8;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(120, 192);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(150, 36);
            this.cbGioiTinh.TabIndex = 9;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Location = new System.Drawing.Point(20, 232);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(100, 23);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 229);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 34);
            this.txtDiaChi.TabIndex = 11;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // grpKyThi
            // 
            this.grpKyThi.Controls.Add(this.label2);
            this.grpKyThi.Controls.Add(this.label1);
            this.grpKyThi.Controls.Add(this.lblKyThi);
            this.grpKyThi.Controls.Add(this.cbKyThi);
            this.grpKyThi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpKyThi.Location = new System.Drawing.Point(20, 356);
            this.grpKyThi.Name = "grpKyThi";
            this.grpKyThi.Size = new System.Drawing.Size(778, 94);
            this.grpKyThi.TabIndex = 2;
            this.grpKyThi.TabStop = false;
            this.grpKyThi.Text = "Thông tin kỳ thi";
            // 
            // lblKyThi
            // 
            this.lblKyThi.Location = new System.Drawing.Point(20, 35);
            this.lblKyThi.Name = "lblKyThi";
            this.lblKyThi.Size = new System.Drawing.Size(174, 33);
            this.lblKyThi.TabIndex = 0;
            this.lblKyThi.Text = "Danh sách kỳ thi:";
            // 
            // cbKyThi
            // 
            this.cbKyThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKyThi.Items.AddRange(new object[] {
            "Chứng chỉ tin học A",
            "Kỳ thi trắc nghiệm lập trình",
            "Kỳ thi tiếng Anh B1"});
            this.cbKyThi.Location = new System.Drawing.Point(200, 35);
            this.cbKyThi.Name = "cbKyThi";
            this.cbKyThi.Size = new System.Drawing.Size(257, 36);
            this.cbKyThi.TabIndex = 1;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepTuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.Location = new System.Drawing.Point(480, 456);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(140, 45);
            this.btnTiepTuc.TabIndex = 1;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = false;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.Gray;
            this.btnKetThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.Location = new System.Drawing.Point(640, 456);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(140, 45);
            this.btnKetThuc.TabIndex = 0;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(463, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Số câu hỏi: 60";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(606, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thời gian: 120";
            // 
            // FrmThiSinh
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 552);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.grpKyThi);
            this.Controls.Add(this.grpThiSinh);
            this.Controls.Add(this.panelHeader);
            this.Name = "FrmThiSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký thí sinh";
            this.panelHeader.ResumeLayout(false);
            this.grpThiSinh.ResumeLayout(false);
            this.grpThiSinh.PerformLayout();
            this.grpKyThi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThiSinh;
        private System.Windows.Forms.Label lblMaSV, lblHoTen, lblNgaySinh, lblNoiSinh, lblGioiTinh, lblDiaChi;
        private System.Windows.Forms.TextBox txtMaSV, txtHoTen, txtNgaySinh, txtNoiSinh, txtDiaChi;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.GroupBox grpKyThi;
        private System.Windows.Forms.Label lblKyThi;
        private System.Windows.Forms.ComboBox cbKyThi;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
using System.Drawing;
using System.Windows.Forms;

namespace MyThi_490.GUI
{
    partial class Quanlycovan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblMaCV = new System.Windows.Forms.Label();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.lblTenCV = new System.Windows.Forms.Label();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.dgvCoVan = new System.Windows.Forms.DataGridView();
            this.colMaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoVan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblMaCV);
            this.panelTop.Controls.Add(this.txtMaCV);
            this.panelTop.Controls.Add(this.lblTenCV);
            this.panelTop.Controls.Add(this.txtTenCV);
            this.panelTop.Controls.Add(this.lblKhoa);
            this.panelTop.Controls.Add(this.cbKhoa);
            this.panelTop.Controls.Add(this.btnThem);
            this.panelTop.Controls.Add(this.btnSua);
            this.panelTop.Controls.Add(this.btnXoa);
            this.panelTop.Controls.Add(this.btnLamMoi);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 200);
            this.panelTop.TabIndex = 0;
            // 
            // lblMaCV
            // 
            this.lblMaCV.Location = new System.Drawing.Point(30, 75);
            this.lblMaCV.Name = "lblMaCV";
            this.lblMaCV.Size = new System.Drawing.Size(118, 25);
            this.lblMaCV.TabIndex = 1;
            this.lblMaCV.Text = "Mã Cố vấn:";
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(154, 72);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(176, 34);
            this.txtMaCV.TabIndex = 2;
            // 
            // lblTenCV
            // 
            this.lblTenCV.Location = new System.Drawing.Point(350, 75);
            this.lblTenCV.Name = "lblTenCV";
            this.lblTenCV.Size = new System.Drawing.Size(80, 25);
            this.lblTenCV.TabIndex = 3;
            this.lblTenCV.Text = "Họ tên:";
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(430, 72);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(300, 34);
            this.txtTenCV.TabIndex = 4;
            // 
            // lblKhoa
            // 
            this.lblKhoa.Location = new System.Drawing.Point(750, 75);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(60, 25);
            this.lblKhoa.TabIndex = 5;
            this.lblKhoa.Text = "Khoa:";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Location = new System.Drawing.Point(810, 72);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(220, 36);
            this.cbKhoa.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(130, 130);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 45);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(270, 130);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 45);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(410, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 45);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(550, 130);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 45);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.dgvCoVan);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 200);
            this.panelFill.Name = "panelFill";
            this.panelFill.Padding = new System.Windows.Forms.Padding(20);
            this.panelFill.Size = new System.Drawing.Size(1200, 500);
            this.panelFill.TabIndex = 0;
            // 
            // dgvCoVan
            // 
            this.dgvCoVan.AllowUserToAddRows = false;
            this.dgvCoVan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoVan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoVan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCoVan.ColumnHeadersHeight = 35;
            this.dgvCoVan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCV,
            this.colTenCV,
            this.colKhoa});
            this.dgvCoVan.EnableHeadersVisualStyles = false;
            this.dgvCoVan.Location = new System.Drawing.Point(0, 0);
            this.dgvCoVan.Name = "dgvCoVan";
            this.dgvCoVan.ReadOnly = true;
            this.dgvCoVan.RowHeadersWidth = 62;
            this.dgvCoVan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoVan.Size = new System.Drawing.Size(1200, 480);
            this.dgvCoVan.TabIndex = 0;
            // 
            // colMaCV
            // 
            this.colMaCV.HeaderText = "Mã Cố Vấn";
            this.colMaCV.MinimumWidth = 8;
            this.colMaCV.Name = "colMaCV";
            this.colMaCV.ReadOnly = true;
            // 
            // colTenCV
            // 
            this.colTenCV.HeaderText = "Họ và Tên";
            this.colTenCV.MinimumWidth = 8;
            this.colTenCV.Name = "colTenCV";
            this.colTenCV.ReadOnly = true;
            // 
            // colKhoa
            // 
            this.colKhoa.HeaderText = "Khoa Quản Lý";
            this.colKhoa.MinimumWidth = 8;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.ReadOnly = true;
            // 
            // Quanlycovan
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Quanlycovan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Cố vấn Học tập";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoVan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblMaCV, lblTenCV, lblKhoa;
        private System.Windows.Forms.TextBox txtMaCV, txtTenCV;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.DataGridView dgvCoVan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCV, colTenCV, colKhoa;
    }
}
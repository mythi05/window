using System.Drawing;

namespace MyThi_490.GUI
{
    partial class Quanlydiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSinhVien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.btnLuuDiem = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.colSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.cbSinhVien);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.cbMonHoc);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.txtDiem);
            this.panelTop.Controls.Add(this.btnLuuDiem);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 200);
            this.panelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sinh viên:";
            // 
            // cbSinhVien
            // 
            this.cbSinhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSinhVien.Location = new System.Drawing.Point(139, 70);
            this.cbSinhVien.Name = "cbSinhVien";
            this.cbSinhVien.Size = new System.Drawing.Size(250, 36);
            this.cbSinhVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(400, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Môn học:";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonHoc.Location = new System.Drawing.Point(480, 72);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(280, 36);
            this.cbMonHoc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(800, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điểm số:";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(870, 72);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(100, 34);
            this.txtDiem.TabIndex = 6;
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLuuDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuDiem.ForeColor = System.Drawing.Color.White;
            this.btnLuuDiem.Location = new System.Drawing.Point(120, 125);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(150, 45);
            this.btnLuuDiem.TabIndex = 7;
            this.btnLuuDiem.Text = "Cập nhật điểm";
            this.btnLuuDiem.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.dgvKetQua);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 200);
            this.panelFill.Name = "panelFill";
            this.panelFill.Padding = new System.Windows.Forms.Padding(20);
            this.panelFill.Size = new System.Drawing.Size(1200, 500);
            this.panelFill.TabIndex = 0;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKetQua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKetQua.ColumnHeadersHeight = 35;
            this.dgvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSV,
            this.colMon,
            this.colDiem});
            this.dgvKetQua.EnableHeadersVisualStyles = false;
            this.dgvKetQua.Location = new System.Drawing.Point(0, 0);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(1200, 480);
            this.dgvKetQua.TabIndex = 0;
            // 
            // colSV
            // 
            this.colSV.HeaderText = "Mã Sinh Viên";
            this.colSV.MinimumWidth = 8;
            this.colSV.Name = "colSV";
            this.colSV.ReadOnly = true;
            // 
            // colMon
            // 
            this.colMon.HeaderText = "Mã Môn Học";
            this.colMon.MinimumWidth = 8;
            this.colMon.Name = "colMon";
            this.colMon.ReadOnly = true;
            // 
            // colDiem
            // 
            this.colDiem.HeaderText = "Điểm Số";
            this.colDiem.MinimumWidth = 8;
            this.colDiem.Name = "colDiem";
            this.colDiem.ReadOnly = true;
            // 
            // Quanlydiem
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Quanlydiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Điểm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1, label2, label3;
        private System.Windows.Forms.ComboBox cbSinhVien, cbMonHoc;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Button btnLuuDiem;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSV, colMon, colDiem;
    }
}
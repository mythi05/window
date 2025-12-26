namespace MyThi_490.Baitap
{
    partial class Bai28
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeight = 34;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(560, 200);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // colId
            // 
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            this.colId.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên nhân viên";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Tuổi";
            this.colAge.MinimumWidth = 8;
            this.colAge.Name = "colAge";
            this.colAge.Width = 150;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Nam";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            this.colGender.Width = 150;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(100, 230);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(264, 26);
            this.tbId.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 260);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(264, 26);
            this.tbName.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(100, 290);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(264, 26);
            this.tbAge.TabIndex = 3;
            // 
            // ckGender
            // 
            this.ckGender.Location = new System.Drawing.Point(100, 320);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(104, 24);
            this.ckGender.TabIndex = 4;
            this.ckGender.Text = "Nam";
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(300, 350);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 38);
            this.btAddNew.TabIndex = 5;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(390, 350);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 38);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(480, 350);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 38);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(26, 230);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(63, 23);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Mã";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(26, 260);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 23);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Tên";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(26, 290);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(63, 23);
            this.lblAge.TabIndex = 10;
            this.lblAge.Text = "Tuổi";
            // 
            // Bai28
            // 
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExit);
            this.Name = "Bai28";
            this.Text = "Bài 20 - Manual";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId, colName, colAge;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete, btExit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
    }
}
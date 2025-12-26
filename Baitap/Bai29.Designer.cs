namespace MyThi_490.Baitap
{
    partial class Bai29
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

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colAge,
            this.colGender});
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(600, 200);
            this.dgvEmployee.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Mã nhân viên";
            this.colId.MinimumWidth = 8;
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên nhân viên";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Tuổi";
            this.colAge.MinimumWidth = 8;
            this.colAge.Name = "colAge";
            this.colAge.Width = 80;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Giới tính (Nam)";
            this.colGender.MinimumWidth = 8;
            this.colGender.Name = "colGender";
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(30, 230);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 23);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Mã";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(30, 260);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Tên";
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(30, 290);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(84, 23);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Tuổi";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(120, 230);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(150, 26);
            this.tbId.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(120, 260);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 26);
            this.tbName.TabIndex = 4;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(120, 290);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(150, 26);
            this.tbAge.TabIndex = 6;
            // 
            // ckGender
            // 
            this.ckGender.Location = new System.Drawing.Point(120, 320);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(104, 24);
            this.ckGender.TabIndex = 7;
            this.ckGender.Text = "Nam";
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(300, 350);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 23);
            this.btAddNew.TabIndex = 8;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(400, 350);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(500, 350);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 10;
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Bai29
            // 
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btExit);
            this.Name = "Bai29";
            this.Text = "Bài 22 - BindingSource";
            this.Load += new System.EventHandler(this.Bai29_Load);
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
        private System.Windows.Forms.Label lblId, lblName, lblAge;
    }
}
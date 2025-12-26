namespace MyThi_490.Baitap
{
    partial class Bai30
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(600, 180);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(104, 210);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(250, 26);
            this.tbId.TabIndex = 1;
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(100, 240);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(254, 26);
            this.tbName.TabIndex = 2;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(100, 270);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(254, 26);
            this.tbAge.TabIndex = 3;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // ckGender
            // 
            this.ckGender.Location = new System.Drawing.Point(100, 300);
            this.ckGender.Name = "ckGender";
            this.ckGender.Size = new System.Drawing.Size(104, 24);
            this.ckGender.TabIndex = 4;
            this.ckGender.Text = "Nam";
            // 
            // btAddNew
            // 
            this.btAddNew.Location = new System.Drawing.Point(320, 330);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(75, 38);
            this.btAddNew.TabIndex = 5;
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(420, 330);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 38);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(0, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 23);
            this.lblId.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(0, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(100, 23);
            this.lblAge.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(35, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tuổi";
            // 
            // Bai30
            // 
            this.ClientSize = new System.Drawing.Size(624, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Name = "Bai30";
            this.Text = "DataGridView Article 21";
            this.Load += new System.EventHandler(this.Bai21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tbId, tbName, tbAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew, btDelete;
        private System.Windows.Forms.Label lblId, lblName, lblAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
using MyThi_490.GUI;
using System;
using System.Windows.Forms;

namespace MyThi_490
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseAllChildForms()
        {
            foreach (Form frm in this.MdiChildren)
                frm.Close();
        }

        private void menuQLSinhVien_Click(object sender, EventArgs e)
        {
          Quanlysinhvien f = new Quanlysinhvien();
            CloseAllChildForms();
            f.MdiParent = this;
            f.Show();
        }

        private void menuQLKhoa_Click(object sender, EventArgs e)
        {
            Quanlykhoa f = new Quanlykhoa();
            CloseAllChildForms();
            f.MdiParent = this;
            f.Show();  
        }

        private void menuQLLop_Click(object sender, EventArgs e)
        {
           
        }

        private void menuQLCoVan_Click(object sender, EventArgs e)
        {
          
        }

        private void menuQLMonHoc_Click(object sender, EventArgs e)
        {
        
        }
    }
}

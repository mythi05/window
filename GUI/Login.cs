using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThi_490.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login successful!");
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

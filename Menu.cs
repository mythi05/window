using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyThi_490.GUI;    
namespace MyThi_490
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 objForm1 = new Form1();
            objForm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login objForm1 = new Login();
            objForm1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register objForm1 = new Register();
            objForm1.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MainForm objMainForm = new MainForm();
            objMainForm.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Quanlysinhvien objForm1 = new Quanlysinhvien();
            objForm1.Show();
        }

        
    }
}

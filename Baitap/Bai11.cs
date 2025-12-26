using System;
using System.Windows.Forms;

namespace MyThi_490.Baitap
{
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }

        // Khi nhấn nút OK: Tiêu đề Form thay đổi thành định dạng ngày dài (ToLongDateString)
        private void btOK_Click(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToLongDateString();
        }

        // Khi thay đổi giá trị ngày trên lịch: Tiêu đề Form thay đổi thành định dạng ngày ngắn (ToShortDateString)
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}
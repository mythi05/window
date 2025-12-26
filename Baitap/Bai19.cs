using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyThi_490.Baitap
{
    public partial class Bai19 : Form
    {
        PictureBox pbBasket = new PictureBox();

        int xBasket = 300;
        int yBasket;
        int xDelta = 30;

        public Bai19()
        {
            InitializeComponent();
            this.Load += Bai19_Load;
            this.KeyDown += Bai19_KeyDown;
        }

        private void Bai19_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 100);

            // ⭐ ĐẶT GIỎ Ở DƯỚI CÙNG FORM
            yBasket = this.ClientSize.Height - pbBasket.Height - 10;

            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;

            this.Controls.Add(pbBasket);

            try
            {
                pbBasket.Image = Image.FromFile(@"D:\basket.jpg");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy ảnh basket.jpg");
            }
        }

        private void Bai19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right &&
                xBasket < this.ClientSize.Width - pbBasket.Width)
            {
                xBasket += xDelta;
            }

            if (e.KeyCode == Keys.Left && xBasket > 0)
            {
                xBasket -= xDelta;
            }

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}

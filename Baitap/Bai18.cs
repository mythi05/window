using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyThi_490.Baitap
{
    public partial class Bai18 : Form
    {
        PictureBox pbEgg = new PictureBox();
        Timer tmEgg = new Timer();

        int xEgg = 300;
        float yEgg = 0;

        float speedY = 0f;      // vận tốc
        float gravity = 0.25f;  // gia tốc (giảm số này = mượt hơn)

        public Bai18()
        {
            InitializeComponent();
        }

        private void Bai18_Load(object sender, EventArgs e)
        {
            tmEgg.Interval = 15;   // chậm hơn chút cho mượt
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, (int)yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);

            try
            {
                pbEgg.Image = Image.FromFile("../../Images/egg2.png");
            }
            catch { }
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            speedY += gravity;     // tăng tốc dần
            yEgg += speedY;

            // Chạm đất
            if (yEgg >= this.ClientSize.Height - pbEgg.Height)
            {
                yEgg = this.ClientSize.Height - pbEgg.Height;

                try
                {
                    pbEgg.Image = Image.FromFile("../../Images/egg.png");
                }
                catch { }

                tmEgg.Stop(); // dừng khi vỡ → giống game
            }

            pbEgg.Location = new Point(xEgg, (int)yEgg);
        }
    }
}

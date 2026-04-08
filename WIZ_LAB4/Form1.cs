namespace WIZ_LAB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pliki BMP|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void btnOnlyGreen_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    if (c.G > c.R + 20 && c.G > c.B + 20)
                    {
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
                }
            }
            pictureBox1.Image = bmp;
        }
    }
}

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

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Image img = pictureBox1.Image;
            if (rb90.Checked) img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else if (rb180.Checked) img.RotateFlip(RotateFlipType.Rotate180FlipNone);
            else if (rb270.Checked) img.RotateFlip(RotateFlipType.Rotate270FlipNone);

            pictureBox1.Image = img;
            pictureBox1.Refresh();
        }
    }
}

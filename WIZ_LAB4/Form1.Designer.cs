namespace WIZ_LAB4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnLoad = new Button();
            btnOnlyGreen = new Button();
            rb90 = new RadioButton();
            rb180 = new RadioButton();
            rb270 = new RadioButton();
            btnRotate = new Button();
            btnInvert = new Button();
            btnUpsideDown = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(219, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 432);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(21, 396);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(166, 48);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOnlyGreen
            // 
            btnOnlyGreen.BackColor = Color.FromArgb(192, 255, 192);
            btnOnlyGreen.Location = new Point(21, 328);
            btnOnlyGreen.Name = "btnOnlyGreen";
            btnOnlyGreen.Size = new Size(166, 48);
            btnOnlyGreen.TabIndex = 2;
            btnOnlyGreen.Text = "OnlyGreen";
            btnOnlyGreen.UseVisualStyleBackColor = false;
            btnOnlyGreen.Click += btnOnlyGreen_Click;
            // 
            // rb90
            // 
            rb90.AutoSize = true;
            rb90.Checked = true;
            rb90.Location = new Point(21, 12);
            rb90.Name = "rb90";
            rb90.Size = new Size(52, 24);
            rb90.TabIndex = 2;
            rb90.TabStop = true;
            rb90.Text = "90°";
            rb90.UseVisualStyleBackColor = true;
            // 
            // rb180
            // 
            rb180.AutoSize = true;
            rb180.Location = new Point(21, 42);
            rb180.Name = "rb180";
            rb180.Size = new Size(60, 24);
            rb180.TabIndex = 3;
            rb180.Text = "180°";
            rb180.UseVisualStyleBackColor = true;
            // 
            // rb270
            // 
            rb270.AutoSize = true;
            rb270.Location = new Point(21, 72);
            rb270.Name = "rb270";
            rb270.Size = new Size(60, 24);
            rb270.TabIndex = 4;
            rb270.Text = "270°";
            rb270.UseVisualStyleBackColor = true;
            // 
            // btnRotate
            // 
            btnRotate.BackColor = Color.FromArgb(255, 128, 128);
            btnRotate.Location = new Point(21, 102);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(166, 48);
            btnRotate.TabIndex = 5;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = false;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnInvert
            // 
            btnInvert.BackColor = Color.FromArgb(192, 192, 255);
            btnInvert.Location = new Point(21, 156);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(166, 48);
            btnInvert.TabIndex = 6;
            btnInvert.Text = "Invert Colors";
            btnInvert.UseVisualStyleBackColor = false;
            btnInvert.Click += btnInvert_Click;
            // 
            // btnUpsideDown
            // 
            btnUpsideDown.BackColor = Color.FromArgb(192, 192, 255);
            btnUpsideDown.Location = new Point(21, 210);
            btnUpsideDown.Name = "btnUpsideDown";
            btnUpsideDown.Size = new Size(166, 48);
            btnUpsideDown.TabIndex = 7;
            btnUpsideDown.Text = "Upside Down";
            btnUpsideDown.UseVisualStyleBackColor = false;
            btnUpsideDown.Click += btnUpsideDown_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 450);
            Controls.Add(btnOnlyGreen);
            Controls.Add(btnUpsideDown);
            Controls.Add(btnInvert);
            Controls.Add(btnRotate);
            Controls.Add(rb270);
            Controls.Add(rb180);
            Controls.Add(rb90);
            Controls.Add(btnLoad);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLoad;
        private Button btnOnlyGreen;
        private RadioButton rb90;
        private RadioButton rb180;
        private RadioButton rb270;
        private Button btnRotate;
        private Button btnInvert;
        private Button btnUpsideDown;
    }
}

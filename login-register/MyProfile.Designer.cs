namespace login_register
{
    partial class MyProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pfpBox = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pfpBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pfpBox
            // 
            pfpBox.Location = new Point(322, 72);
            pfpBox.Name = "pfpBox";
            pfpBox.Size = new Size(150, 150);
            pfpBox.TabIndex = 0;
            pfpBox.TabStop = false;
            pfpBox.Click += pfpBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.Location = new Point(-9, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 300);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(782, 453);
            Controls.Add(pfpBox);
            Controls.Add(pictureBox1);
            Name = "MyProfile";
            Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)pfpBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pfpBox;
        private PictureBox pictureBox1;
    }
}
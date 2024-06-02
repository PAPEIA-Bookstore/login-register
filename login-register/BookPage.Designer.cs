namespace login_register
{
    partial class BookPage
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
            pictureBox1 = new PictureBox();
            bookTitle = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._71wM_BB9mtL__AC_UF1000_1000_QL80_;
            pictureBox1.Location = new Point(35, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // bookTitle
            // 
            bookTitle.AutoSize = true;
            bookTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookTitle.Location = new Point(334, 24);
            bookTitle.Name = "bookTitle";
            bookTitle.Size = new Size(60, 32);
            bookTitle.TabIndex = 1;
            bookTitle.Text = "Title";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(334, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(336, 134);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // BookPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(bookTitle);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookPage";
            Text = "BookPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label bookTitle;
        private RichTextBox richTextBox1;
    }
}
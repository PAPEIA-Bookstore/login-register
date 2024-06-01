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
            pictureBox1 = new PictureBox();
            usernameLabel = new Label();
            pfpBox = new PictureBox();
            exitButton = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pfpBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 45);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Tan;
            usernameLabel.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.PapayaWhip;
            usernameLabel.Location = new Point(130, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(65, 26);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "label2";
            usernameLabel.Click += label2_Click;
            // 
            // pfpBox
            // 
            pfpBox.BackColor = Color.Tan;
            pfpBox.Location = new Point(84, 2);
            pfpBox.Name = "pfpBox";
            pfpBox.Size = new Size(40, 40);
            pfpBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pfpBox.TabIndex = 26;
            pfpBox.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tan;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Candara", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.PapayaWhip;
            exitButton.Location = new Point(642, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(35, 35);
            exitButton.TabIndex = 27;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Tan;
            pictureBox2.BackgroundImage = Properties.Resources.book_41626;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Tan;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.PapayaWhip;
            textBox1.Location = new Point(362, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 31);
            textBox1.TabIndex = 29;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.PapayaWhip;
            button1.Location = new Point(529, -2);
            button1.Name = "button1";
            button1.Size = new Size(35, 45);
            button1.TabIndex = 30;
            button1.Text = "⌕";
            button1.UseVisualStyleBackColor = false;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(684, 340);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(exitButton);
            Controls.Add(pfpBox);
            Controls.Add(usernameLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pfpBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label usernameLabel;
        private Label label3;
        private PictureBox pfpBox;
        private Button exitButton;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Button button1;
    }
}
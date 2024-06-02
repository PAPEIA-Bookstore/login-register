namespace login_register
{
    partial class ContainerForm
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
            usernameLabel = new Label();
            pfpBox = new PictureBox();
            exitButton = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pfpBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Tan;
            usernameLabel.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.PapayaWhip;
            usernameLabel.Location = new Point(136, 27);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(65, 26);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "label2";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // pfpBox
            // 
            pfpBox.BackColor = Color.Tan;
            pfpBox.Location = new Point(90, 22);
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
            exitButton.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.ForeColor = Color.PapayaWhip;
            exitButton.Location = new Point(1033, 21);
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
            pictureBox2.Location = new Point(12, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 610);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(exitButton);
            panel2.Controls.Add(pfpBox);
            panel2.Controls.Add(usernameLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1089, 84);
            panel2.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 15.75F);
            label1.Location = new Point(832, 27);
            label1.Name = "label1";
            label1.Size = new Size(152, 26);
            label1.TabIndex = 29;
            label1.Text = "Login / Register";
            label1.Click += label1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.Image = Properties.Resources.text_1717247010360;
            pictureBox1.Location = new Point(365, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // ContainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1089, 692);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ContainerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)pfpBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label usernameLabel;
        private Label label3;
        private PictureBox pfpBox;
        private Button exitButton;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
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
            fullNameLabel = new Label();
            usernameLabel = new Label();
            button1 = new Button();
            pfpBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pfpBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Tan;
            pictureBox1.Location = new Point(-8, 117);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(700, 225);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.BackColor = Color.Tan;
            fullNameLabel.Font = new Font("Candara", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullNameLabel.ForeColor = Color.PapayaWhip;
            fullNameLabel.Location = new Point(159, 117);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(92, 39);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "label1";
            fullNameLabel.Click += label1_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Tan;
            usernameLabel.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.PapayaWhip;
            usernameLabel.Location = new Point(159, 156);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(65, 26);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "label2";
            usernameLabel.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(636, 12);
            button1.Name = "button1";
            button1.Size = new Size(36, 31);
            button1.TabIndex = 25;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pfpBox
            // 
            pfpBox.BackColor = Color.Tan;
            pfpBox.Location = new Point(33, 62);
            pfpBox.Name = "pfpBox";
            pfpBox.Size = new Size(120, 120);
            pfpBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pfpBox.TabIndex = 26;
            pfpBox.TabStop = false;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(684, 340);
            Controls.Add(pfpBox);
            Controls.Add(button1);
            Controls.Add(usernameLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MyProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pfpBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label fullNameLabel;
        private Label usernameLabel;
        private Label label3;
        private Button button1;
        private PictureBox pfpBox;
    }
}
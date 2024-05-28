namespace login_register
{
    partial class loginForm
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
            label6 = new Label();
            label5 = new Label();
            buttonClearLOGIN = new Button();
            buttonLOGIN = new Button();
            checkBoxShowPass = new CheckBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(101, 428);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 23;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(72, 402);
            label5.Name = "label5";
            label5.Size = new Size(149, 17);
            label5.TabIndex = 22;
            label5.Text = "Dont Have An Account";
            // 
            // buttonClearLOGIN
            // 
            buttonClearLOGIN.BackColor = Color.White;
            buttonClearLOGIN.Cursor = Cursors.Hand;
            buttonClearLOGIN.FlatStyle = FlatStyle.Flat;
            buttonClearLOGIN.ForeColor = Color.FromArgb(116, 86, 174);
            buttonClearLOGIN.Location = new Point(43, 345);
            buttonClearLOGIN.Name = "buttonClearLOGIN";
            buttonClearLOGIN.Size = new Size(216, 35);
            buttonClearLOGIN.TabIndex = 21;
            buttonClearLOGIN.Text = "CLEAR";
            buttonClearLOGIN.UseVisualStyleBackColor = false;
            // 
            // buttonLOGIN
            // 
            buttonLOGIN.BackColor = Color.FromArgb(116, 86, 174);
            buttonLOGIN.Cursor = Cursors.Hand;
            buttonLOGIN.FlatAppearance.BorderSize = 0;
            buttonLOGIN.FlatStyle = FlatStyle.Flat;
            buttonLOGIN.ForeColor = Color.White;
            buttonLOGIN.Location = new Point(43, 293);
            buttonLOGIN.Name = "buttonLOGIN";
            buttonLOGIN.Size = new Size(216, 35);
            buttonLOGIN.TabIndex = 20;
            buttonLOGIN.Text = "LOGIN";
            buttonLOGIN.UseVisualStyleBackColor = false;
            buttonLOGIN.Click += buttonLOGIN_Click;
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.FlatStyle = FlatStyle.Flat;
            checkBoxShowPass.ForeColor = Color.FromArgb(224, 224, 224);
            checkBoxShowPass.Location = new Point(140, 252);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(119, 21);
            checkBoxShowPass.TabIndex = 19;
            checkBoxShowPass.Text = "Show Password";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Microsoft New Tai Lue", 14.25F);
            textBoxPassword.Location = new Point(43, 218);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(216, 28);
            textBoxPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(43, 198);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.FromArgb(230, 231, 233);
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Font = new Font("Microsoft New Tai Lue", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.Location = new Point(43, 156);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(216, 28);
            textBoxUserName.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(43, 136);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 13;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(43, 81);
            label1.Name = "label1";
            label1.Size = new Size(155, 27);
            label1.TabIndex = 12;
            label1.Text = "Get Started";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(255, 12);
            button1.Name = "button1";
            button1.Size = new Size(36, 31);
            button1.TabIndex = 24;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(303, 512);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonClearLOGIN);
            Controls.Add(buttonLOGIN);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button buttonClearLOGIN;
        private Button buttonLOGIN;
        private CheckBox checkBoxShowPass;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxUserName;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
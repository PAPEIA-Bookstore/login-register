namespace login_register
{
    partial class formRegister
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
            label1 = new Label();
            user_label = new Label();
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxConfPassword = new TextBox();
            label4 = new Label();
            checkBoxShowPass = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            textBoxFullName = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(39, 37);
            label1.Name = "label1";
            label1.Size = new Size(191, 33);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.ForeColor = Color.Silver;
            user_label.Location = new Point(39, 87);
            user_label.Name = "user_label";
            user_label.Size = new Size(87, 21);
            user_label.TabIndex = 1;
            user_label.Text = "Username";
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.FromArgb(230, 231, 233);
            textBoxUserName.BorderStyle = BorderStyle.None;
            textBoxUserName.Font = new Font("Microsoft New Tai Lue", 14.25F);
            textBoxUserName.Location = new Point(39, 111);
            textBoxUserName.Multiline = true;
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(216, 28);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.TextChanged += textBoxUserName_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(230, 231, 233);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Microsoft New Tai Lue", 14.25F);
            textBoxPassword.Location = new Point(39, 223);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(216, 28);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(39, 199);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // textBoxConfPassword
            // 
            textBoxConfPassword.BackColor = Color.FromArgb(230, 231, 233);
            textBoxConfPassword.BorderStyle = BorderStyle.None;
            textBoxConfPassword.Font = new Font("Microsoft New Tai Lue", 14.25F);
            textBoxConfPassword.Location = new Point(39, 282);
            textBoxConfPassword.Multiline = true;
            textBoxConfPassword.Name = "textBoxConfPassword";
            textBoxConfPassword.PasswordChar = '*';
            textBoxConfPassword.Size = new Size(216, 28);
            textBoxConfPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(39, 262);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.FlatStyle = FlatStyle.Flat;
            checkBoxShowPass.ForeColor = Color.FromArgb(224, 224, 224);
            checkBoxShowPass.Location = new Point(136, 316);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(145, 25);
            checkBoxShowPass.TabIndex = 7;
            checkBoxShowPass.Text = "Show Password";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(116, 86, 174);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(39, 382);
            button1.Name = "button1";
            button1.Size = new Size(216, 35);
            button1.TabIndex = 8;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(116, 86, 174);
            button2.Location = new Point(39, 434);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 9;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(68, 491);
            label5.Name = "label5";
            label5.Size = new Size(204, 21);
            label5.TabIndex = 10;
            label5.Text = "Already Have An Account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(97, 517);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 11;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.BackColor = Color.FromArgb(230, 231, 233);
            textBoxFullName.BorderStyle = BorderStyle.None;
            textBoxFullName.Font = new Font("Microsoft New Tai Lue", 14.25F);
            textBoxFullName.Location = new Point(39, 167);
            textBoxFullName.Multiline = true;
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(216, 28);
            textBoxFullName.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(39, 143);
            label7.Name = "label7";
            label7.Size = new Size(88, 21);
            label7.TabIndex = 12;
            label7.Text = "Full Name";
            label7.Click += label7_Click;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(303, 571);
            Controls.Add(textBoxFullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textBoxConfPassword);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUserName);
            Controls.Add(user_label);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Silver;
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label user_label;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxConfPassword;
        private Label label4;
        private CheckBox checkBoxShowPass;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textBoxFullName;
        private Label label7;
    }
}

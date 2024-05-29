using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login_register
{
    public partial class loginForm : Form
    {
        private NpgsqlConnection DBopen_connection()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=dpg-cp3nb4021fec73bb1ib0-a.frankfurt-postgres.render.com;Port=5432;Database=korribandb;Username=korr_user;Password=1N2F6ODSpntuDaspz4a4oDJ3A0vGMoMK;Trust Server Certificate=true;");
            conn.Open();
            return conn;
        }
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLOGIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUserName.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please complete all required fields!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                NpgsqlConnection connection = DBHandler.OpenConnection();
                NpgsqlCommand command = DBHandler.GetCommand(connection);
                command.CommandText = "SELECT * FROM users WHERE (username = '" + textBoxUserName.Text + "');";
                NpgsqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    //Verify password
                    string pass = textBoxPassword.Text;
                    pass = pass + GLOBALS.pepper;
                    string dbPass = "";
                    string prof_pic = "";
                    if (dataReader.Read())
                    {
                        dbPass = dataReader.GetString(2);
                        prof_pic = dataReader.GetString(4);
                    }
                    bool isMatch = BCrypt.Net.BCrypt.EnhancedVerify(pass, dbPass);
                    if (isMatch)
                    {
                        pictureBox1.Load(prof_pic);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        
                        MessageBox.Show("Welcome " + textBoxUserName.Text + "!", "Login Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (System.Windows.Forms.Application.MessageLoop)
                        {
                            // WinForms app
                            System.Windows.Forms.Application.Exit();
                        }
                        else
                        {
                            // Console app
                            System.Environment.Exit(1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill in the correct password", "Wrong Password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPassword.Clear();
                        textBoxPassword.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Would you like to register?", "This username does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DBHandler.CloseConnection(connection, command);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked) textBoxPassword.PasswordChar = '\0';
            else textBoxPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please complete all required fields!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string username = textBoxUserName.Text;
                string pass = textBoxPassword.Text;
                NpgsqlConnection conn = this.DBopen_connection();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "select username from users where username='" + username + "'and password='" + pass + "'";
                NpgsqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Welcome " + username + " !", "Login Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                comm.Dispose();
                conn.Close();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new formRegister().Show();
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
    }
}

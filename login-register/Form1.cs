using Npgsql;
using System.Data;

namespace login_register
{
    public partial class formRegister : Form 
    {
        //private loginForm login;
        private NpgsqlConnection DBopen_connection()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Host=dpg-cp3nb4021fec73bb1ib0-a.frankfurt-postgres.render.com;Port=5432;Database=korribandb;Username=korr_user;Password=1N2F6ODSpntuDaspz4a4oDJ3A0vGMoMK;Trust Server Certificate=true;");
            conn.Open();
            return conn;
        }
        public formRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "" || textBoxConfPassword.Text == "")
            {
                MessageBox.Show("Please complete all required fienls!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBoxPassword.Text == textBoxConfPassword.Text)
            {
                string username = textBoxUserName.Text;
                string pass = textBoxPassword.Text;
                NpgsqlConnection conn = this.DBopen_connection();
                NpgsqlCommand comm = new NpgsqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = "insert into users (username, password) values ('" + username + "','" + pass + "')";
                NpgsqlDataReader dr = comm.ExecuteReader();
                comm.Dispose();
                conn.Close();

                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
                textBoxConfPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please complete all required fienls!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfPassword.Text = "";
                textBoxPassword.Focus();
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxConfPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
            textBoxConfPassword.Text = "";

            textBoxUserName.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();
        }
    }
}

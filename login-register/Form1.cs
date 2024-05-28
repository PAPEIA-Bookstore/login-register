using Npgsql;
using System.Data;
using System.Text.RegularExpressions;

namespace login_register
{
    public partial class formRegister : Form
    {
        //private loginForm login;
        private static NpgsqlConnection Dbopen_Connection()
        {
            NpgsqlConnection conn = new NpgsqlConnection(Globals.connectionString);
            conn.Open();
            return conn;
        }
        public formRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "" || textBoxConfPassword.Text == "" || textBoxFullName.Text == "")
            {
                MessageBox.Show("Please complete all required fields!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                if (Regex.IsMatch(textBoxUserName.Text,Globals.usernameREGEX))
                {
                    NpgsqlConnection connection = DBHandler.OpenConnection();
                    NpgsqlCommand command = DBHandler.GetCommand(connection);
                    command.CommandText = "SELECT FROM users WHERE (username = '" + textBoxUserName.Text + "')";
                    NpgsqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows == false) {

                        if (textBoxPassword.Text == textBoxConfPassword.Text)
                        {
                            string username = textBoxUserName.Text;
                            string fullName = textBoxFullName.Text;
                            //  Hashing
                            string pass = textBoxPassword.Text;
                            pass = pass + Globals.pepper;
                            string hashedPass = BCrypt.Net.BCrypt.EnhancedHashPassword(pass, 11);
                            bool is_author = authorCheckBox.Checked;
                            NpgsqlConnection conn = Dbopen_Connection();
                            NpgsqlCommand comm = new NpgsqlCommand();
                            comm.Connection = conn;
                            comm.CommandType = CommandType.Text;
                            comm.CommandText = "INSERT INTO users VALUES ('" + username + "','" + fullName + "', '" + hashedPass + "', '" + is_author + "', 'https://image.png')";
                            NpgsqlDataReader dr = comm.ExecuteReader();
                            comm.Dispose();
                            conn.Close();

                            textBoxUserName.Text = "";
                            textBoxFullName.Text = "";
                            textBoxPassword.Text = "";
                            textBoxConfPassword.Text = "";

                            MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        } else {
                            MessageBox.Show("Please confirm your password", "Passwords Don't Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxPassword.Clear();    
                            textBoxConfPassword.Clear();
                            textBoxPassword.Focus();
                        }

                    } else {
                        MessageBox.Show("Please choose a different username", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserName.Clear();
                        textBoxUserName.Focus();
                    }
                    dataReader.Close();

                } else {
                    MessageBox.Show(Globals.usernameGuidelines, "Incorect Username", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBoxUserName.Clear();
                    textBoxUserName.Focus();
                }
                
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

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

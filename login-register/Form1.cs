using Npgsql;
using System.Data;
using System.Text.RegularExpressions;

namespace login_register
{
    public partial class formRegister : Form
    {
        public formRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Ensure all fields are filled
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "" || textBoxConfPassword.Text == "" || textBoxFullName.Text == "")
            {
                MessageBox.Show("Please complete all required fields!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                //  Correct username form
                if (Regex.IsMatch(textBoxUserName.Text,Globals.usernameREGEX))
                {
                    NpgsqlConnection connection = DBHandler.OpenConnection();
                    NpgsqlCommand command = DBHandler.GetCommand(connection);
                    command.CommandText = "SELECT FROM users WHERE (username = '" + textBoxUserName.Text + "')";
                    NpgsqlDataReader dataReader = command.ExecuteReader();

                    bool usernameExists = dataReader.HasRows;
                    dataReader.Close();
                    //  Check for username uniqueness
                    if (!usernameExists)
                    {
                        //  Check that password is confirmed
                        if (textBoxPassword.Text == textBoxConfPassword.Text)
                        {
                            //  Check that password is strong
                            if (Regex.IsMatch(textBoxPassword.Text, Globals.passREGEX))
                            {
                                string username = textBoxUserName.Text;
                                string fullName = textBoxFullName.Text;
                                //  Hashing
                                string pass = textBoxPassword.Text;
                                pass = pass + Globals.pepper;
                                string hashedPass = BCrypt.Net.BCrypt.EnhancedHashPassword(pass, 11);
                                bool is_author = authorCheckBox.Checked;
                                //  Inserting to db
                                command.CommandText = "INSERT INTO users VALUES ('" + username + "','" + fullName + "', '" + hashedPass + "', '" + is_author + "', 'https://image.png')";
                                command.ExecuteNonQuery();

                                textBoxUserName.Clear();
                                textBoxFullName.Clear();
                                textBoxPassword.Clear();
                                textBoxConfPassword.Clear();

                                MessageBox.Show("Your account has been successfully created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DBHandler.CloseConnection(connection, command);
                            }
                            else
                            {
                                MessageBox.Show(Globals.passGuidelines, "Please choose a stronger password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else
                        {
                            MessageBox.Show("Please confirm your password", "Passwords Don't Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxPassword.Clear();
                            textBoxConfPassword.Clear();
                            textBoxPassword.Focus();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Please choose a different username", "Username Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUserName.Clear();
                        textBoxUserName.Focus();
                    }

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

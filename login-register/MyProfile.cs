using login_register.Properties;
using Npgsql;

namespace login_register
{
    public partial class MyProfile : Form
    {
        private User User;
        private int stars;
        public MyProfile(User User)
        {
            InitializeComponent();
            this.User = User;
            this.stars = 0;
            pfpBox.Load(User.GetProfilePic());
            usernameLabel.Text = "@" + User.GetUsername();
        }

        private void pfpBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void star1_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_outline;
            star2.Image = Resources.star_empty;
            star3.Image = Resources.star_empty;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 1;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_outline;
            star2.Image = Resources.star_outline;
            star3.Image = Resources.star_empty;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 2;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_outline;
            star2.Image = Resources.star_outline;
            star3.Image = Resources.star_outline;
            star4.Image = Resources.star_empty;
            star5.Image = Resources.star_empty;
            stars = 3;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_outline;
            star2.Image = Resources.star_outline;
            star3.Image = Resources.star_outline;
            star4.Image = Resources.star_outline;
            star5.Image = Resources.star_empty;
            stars = 4;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star_outline;
            star2.Image = Resources.star_outline;
            star3.Image = Resources.star_outline;
            star4.Image = Resources.star_outline;
            star5.Image = Resources.star_outline;
            stars = 5;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            string text = richTextBox1.Text;
            DateTime time = DateTime.Now;
            string isbn = "978-960-306-923-2";
            NpgsqlConnection connection =  DBHandler.OpenConnection();
            NpgsqlCommand command = DBHandler.GetCommand(connection);
            command.CommandText = "INSERT INTO REVIEWS(username, isbn, text, stars, time) VALUES('" + User.GetUsername() + "', '" + isbn + "', '" + text + "', " + stars + ", '" + time.ToString() + "');";
            command.ExecuteNonQuery();

        }
    }
}

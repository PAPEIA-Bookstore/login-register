using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//panel1 -> form container
//panel2 -> menu
namespace login_register
{
    public partial class ContainerForm : Form
    {
        private User User;
        public ContainerForm(User User)
        {
            InitializeComponent();
            this.User = User;
            pfpBox.Load(User.GetProfilePic());
            usernameLabel.Text = "@" + User.GetUsername();
            loadform(new HomePage());
        }
        /*
         Η συνάρτηση που διαχειρίζεται το container panel (panel1)
         Δίνει στο panel1 έλεγχο στην φόρμα που δέχεται ως παράμετρο
         */
       public void loadform(object Form)
        {
          if(this.panel1.Controls.Count > 0) this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            if (User.GetAuthor() == true)
            {
                loadform(new AuthorPage());
            }
            else
            {
                loadform(new UserPage());
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            loadform(new HomePage());
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            //Delete user object 
            //
        }
    }
}

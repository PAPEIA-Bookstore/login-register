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
    public partial class MyProfile : Form
    {
        private User User;
        public MyProfile(User User)
        {
            InitializeComponent();
            this.User = User;
            pfpBox.Load(User.GetProfilePic());
            pfpBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pfpBox_Click(object sender, EventArgs e)
        {

        }
    }
}

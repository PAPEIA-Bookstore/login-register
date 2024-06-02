using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_register
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }


        private void AddBookToUI(Book book)
        {
            //Create panel
            Panel panel;
            panel = new Panel();
            panel.Name = String.Format("BookPanel{0}", book.isbn);
            panel.BackColor = Color.White;
            panel.Size = new Size(125, 205);
            panel.Margin = new Padding(10);
            panel.Tag = book.isbn;

            //Add panel to flowlayoutpanel
           // flowLayoutPanel1.Controls.Add(panel1);

            //Create picture box
            PictureBox picBox;
            picBox = new PictureBox();
            picBox.Name = String.Format("BookPanel{0}", book.isbn);
            picBox.Size = new Size(100, 148);
            picBox.Location = new Point(12, 10);
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.Image = Properties.Resources._71wM_BB9mtL__AC_UF1000_1000_QL80_;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.Tag = book.isbn;

            //Create title label
            Label titleLabel;
            titleLabel = new Label();
            titleLabel.Name = String.Format("bookTitleLabel{0}", book.isbn);
            titleLabel.Text = book.title;
            titleLabel.Location = new Point(12, 165);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            titleLabel.AutoSize = true;
            titleLabel.Tag = book.isbn;

            //Create author label
            Label authorLabel;
            authorLabel = new Label();
            authorLabel.Name = String.Format("bookAuthorLabel{0}", book.isbn);
            authorLabel.Text = book.author;
            authorLabel.Location = new Point(12, 185);
            authorLabel.ForeColor = Color.Black;
            authorLabel.Font = new Font(this.Font.FontFamily, 9.5f, FontStyle.Regular);
            authorLabel.Tag = book.isbn;

            //Add controls to panel
            panel.Controls.Add(picBox);
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(authorLabel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book("12hddye","Scary Stories", "kapoios", "blablabla", "horror", 200, "ldldld");
            AddBookToUI(book);
  

        }
}
}

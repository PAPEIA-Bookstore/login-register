using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_register
{
    internal class Book
    {
        public string isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string plot { get; set; }
        public string category { get; set; }
        public int price { get; set; }
        public string cover { get; set; }//link

        //constructor of book object
        public Book(string isbn, string title, string author, string plot, string category , int price, string cover)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.plot = plot;
            this.category = category;
            this.price = price;
            this.cover = cover;
        }

    }
}

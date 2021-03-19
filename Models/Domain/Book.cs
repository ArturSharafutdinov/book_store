using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class Book
    {
        public int bookId { get; set; }

        public string name { get; set; }

        public int pages { get; set; }

        public double price { get; set; }

        public string image { get; set; }

        public string author { get; set; }

        public Publisher publisher { get; set; }

        public Category category { get; set; }

        public Book() { }

        public Book (string name, int pages, double price, string image, string author, Publisher publisher, Category category)
        {
            this.name = name;
            this.pages = pages;
            this.price = price;
            this.image = image;
            this.author = author;
            this.publisher = publisher;
            this.category = category;
        }
    }
}

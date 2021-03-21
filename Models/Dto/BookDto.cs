using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models.Dto
{
    public class BookDto
    {
        public int bookId { get; set; }

        public string name { get; set; }

        public int pages { get; set; }

        public double price { get; set; }

        public string image { get; set; }

        public string author { get; set; }

        public string publisherName { get; set; }

        public string categoryName { get; set; }

        public int kolvo { get; set; }

        public BookDto(int bookId, string name, int pages, double price, string image, string author, string publisherName, string categoryName, int kolvo)
        {
            this.bookId = bookId;
            this.name = name;
            this.pages = pages;
            this.price = price;
            this.image = image;
            this.author = author;
            this.publisherName = publisherName;
            this.categoryName = categoryName;
            this.kolvo = kolvo;
        }
    }
}

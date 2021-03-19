using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class OrderBook
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int kolvo { get; set; }
        public int bookId { get; set; }

        public OrderBook() { }

        public OrderBook(int kolvo, int bookId)
        {
            this.kolvo = kolvo;
            this.bookId = bookId;
        }
    }
}

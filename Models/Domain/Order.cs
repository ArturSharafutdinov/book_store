using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class Order
    {

        public int orderId { get; set; }
        public DateTime date { get; set; }
        public string delivery_type { get; set; }
        public bool bonus { get; set; }
        public User customer { get; set; }
        public List<OrderBook> order { get; set; }

        public Order() { }

        public Order(DateTime date, string delivery_type, bool bonus, User customer, List<OrderBook> order)
        {
            this.date = date;
            this.delivery_type = delivery_type;
            this.bonus = bonus;
            this.customer = customer;
            this.order = order;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models.Dto
{
    public class OrderDto
    {
        public int orderId { get; set; }
        public string delivery_type { get; set; }
        public bool bonus { get; set; }
        public string customerName { get; set; }
        public string userId { get; set; }
       public OrderBookDto[] orders { get; set; }

        public OrderDto()
        {
        }

        public OrderDto(int orderId, string delivery_type, bool bonus, string customerName, string userId, OrderBookDto[] orders)
        {
            this.orderId = orderId;
            this.delivery_type = delivery_type;
            this.bonus = bonus;
            this.customerName = customerName;
            this.userId = userId;
            this.orders = orders;
        }
    }
}

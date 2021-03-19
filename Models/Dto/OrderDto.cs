using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models.Dto
{
    public class OrderDto
    {
        public string delivery_type { get; set; }
        public bool bonus { get; set; }
        public string customerName { get; set; }
        public string userId { get; set; }
        public OrderBookDto[] orders { get; set; }


    }
}

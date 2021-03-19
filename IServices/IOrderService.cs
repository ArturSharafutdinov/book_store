using book_store.Models;
using book_store.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.IServices
{
    public interface IOrderService
    {
        public void addOrder(OrderDto orderDto);

        public IEnumerable<Order> getAllBooks();

        public Order getOrderById(int id);

        public void updateOrder(Order order);

        public void removeOrder(int id);
    }
}

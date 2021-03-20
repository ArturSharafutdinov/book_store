using book_store.IRepositories;
using book_store.IServices;
using book_store.Mappers;
using book_store.Models;
using book_store.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Services
{
    public class OrderService : IOrderService
    {

        private readonly UserManager<User> _userManager;
        private readonly IOrderRepository _orderRep;

        public OrderService(UserManager<User> userManager, IOrderRepository orderRep)
        {
            _userManager = userManager;
            _orderRep = orderRep;
        }

        public void addOrder(OrderDto orderDto)
        {
            User user = _userManager.Users.FirstOrDefault(user => user.UserName == orderDto.customerName);
                if (user != null) {
                Order order = OrderMapper.mapToEntityOrder(orderDto, user);
                _orderRep.Create(order);
                _orderRep.Save();
            }
        }

        public IEnumerable<Order> getAllBooks()
        {
            throw new NotImplementedException();
        }

        public Order getOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public void removeOrder(int id)
        {
            throw new NotImplementedException();
        }

        public void updateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

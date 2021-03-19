using book_store.Models;
using book_store.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Mappers
{
    public class OrderMapper
    {

       public static OrderBook mapToEntityOrderBook(OrderBookDto orderBookDto)
        {
            return new OrderBook(orderBookDto.kolvo, orderBookDto.bookId);
        }

        public static Order mapToEntityOrder(OrderDto orderDto, User user)
        {
            List<OrderBook> orders = new List<OrderBook>();
            foreach(OrderBookDto order in orderDto.orders)
            {
                orders.Add(OrderMapper.mapToEntityOrderBook(order));
            }
            return new Order(
                DateTime.Now,
                orderDto.delivery_type,
                orderDto.bonus,
                user,
                orders
                );
        }

    }
}

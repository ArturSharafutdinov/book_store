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

        public static OrderBookDto mapToDtoOrderBook(OrderBook orderBook)
        {
            return new OrderBookDto(orderBook.kolvo, orderBook.bookId);
        }

        public static OrderDto mapToDto(Order order)
        {

            List<OrderBookDto> orders = new List<OrderBookDto>();
            foreach (OrderBook order1 in order.order)
            {
                orders.Add(OrderMapper.mapToDtoOrderBook(order1));
            }
            return new OrderDto(order.orderId,order.delivery_type, order.bonus, order.customer.Email, order.customer.Id, orders.ToArray());
        }

    }
}

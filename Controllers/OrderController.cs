using book_store.IServices;
using book_store.Models;
using book_store.Models.Dto;
using book_store.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;
        private readonly IBookService _bookService;

        public OrderController(IOrderService orderService, IBookService bookService)
        {
            _orderService = orderService;
            _bookService = bookService;
        }


    
        [HttpPost]
        public ActionResult PostOrder(OrderDto orderDto)
            {
            _orderService.addOrder(orderDto);
        //    _bookService.reduceBook(orderDto.orders);

            return Ok();
        }

        [HttpGet("byUserId")]
        public IEnumerable<OrderDto> GetOrdersByUserId(string userId)
        {
            List<OrderDto> orders = _orderService.getOrdersByUserId(userId).ToList();

            foreach(OrderDto orderDto in orders)
            {
                for(int i = 0; i < orderDto.orders.Length; i++)
                {
                    orderDto.orders[i].bookName = _bookService.getBookById(orderDto.orders[i].bookId).name;
                    orderDto.orders[i].bookImage = _bookService.getBookById(orderDto.orders[i].bookId).image;
                }
            }

            return orders;
        }

    }
}

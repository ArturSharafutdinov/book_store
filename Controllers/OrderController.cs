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

        [Authorize]
        [HttpPost]
        public ActionResult<Order> PostOrder(OrderDto orderDto)
        {
            _orderService.addOrder(orderDto);
            _bookService.reduceBook(orderDto.orders);

            return Ok("Order added");
        }

    }
}

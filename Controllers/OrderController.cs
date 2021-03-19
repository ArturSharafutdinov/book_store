using book_store.Models;
using book_store.Models.Dto;
using book_store.Services;
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

        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(OrderDto orderDto)
        {
            _orderService.addOrder(orderDto);
            return Ok("Book added");
        }

    }
}

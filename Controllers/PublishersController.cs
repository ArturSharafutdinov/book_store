using book_store.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly BooksContext _booksContext;

        public PublishersController(BooksContext booksContext)
        {
            _booksContext = booksContext;
        }

        [HttpPost]
        public ActionResult PostPublisher(Publisher publisher)
        {
            _booksContext.Publishers.Add(publisher);
            _booksContext.SaveChanges();
            return Ok("added");
        }

        [HttpGet]
        public ActionResult<IEnumerable<Publisher>> GetPublishers()
        {
            return _booksContext.Publishers.ToList();
        }

       
    }
}

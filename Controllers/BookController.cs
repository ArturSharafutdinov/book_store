using AutoMapper;
using book_store.IServices;
using book_store.Models;
using book_store.Models.Dto;
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
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }


        // GET: api/Books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _bookService.getAllBooks().OrderBy(q => q.bookId).ToList();
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            return _bookService.getBookById(id);
        }

        // POST: api/Books
        [HttpPost]
        public ActionResult<Book> PostBook(BookDto bookDto)
        {
            _bookService.addBook(bookDto);
            return Ok("Book added");
        }

        [Authorize]
        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            var book = _bookService.getBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            _bookService.removeBook(id);

            return Ok("removed");
        }

    }
}

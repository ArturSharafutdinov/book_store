using AutoMapper;
using book_store.IServices;
using book_store.Mappers;
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
        private readonly IPublisherService publisherService;
        private readonly ICategoryService categoryService;

        public BooksController(IBookService bookService, IPublisherService publisherService, ICategoryService categoryService)
        {
            _bookService = bookService;
            this.publisherService = publisherService;
            this.categoryService = categoryService;
        }




        // GET: api/Books
        [HttpGet]
        public ActionResult<IEnumerable<BookDto>> GetBooks()
        {
            List<BookDto> books = new List<BookDto>();
           foreach(Book book in _bookService.getAllBooks().ToList())
            {
                string publisher = _bookService.GetPublisher(book.bookId).name;
                string category = _bookService.GetCategory(book.bookId).name;

                books.Add(BookMapper.mapToDto(book,publisher,category));
            }
            return books;
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

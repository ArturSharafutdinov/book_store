using AutoMapper;
using book_store.IServices;
using book_store.Models;
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
        private readonly BooksContext _booksContext;
        private readonly IMapper _mapper;

        public BooksController(IBookService bookService, BooksContext booksContext, IMapper mapper)
        {
            _bookService = bookService;
            _booksContext = booksContext;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("/publisher")]
        public ActionResult addPublisher(Publisher publisher)
        {
            _booksContext.Publishers.Add(publisher);
            _booksContext.SaveChanges();
            return Ok("added");
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

        // PUT: api/Books/5
        [HttpPut("{id}")]
        public IActionResult PutBook(int id, Book book)
        {

            _bookService.updateBook(book);
            return Ok("changed");

        }

        // POST: api/Books
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {

            await _booksContext.AddAsync(book);
            await _booksContext.SaveChangesAsync();

            int lastId = _booksContext.Books.ToList().Max(x => x.bookId);

            return _booksContext.Books.Find(lastId);
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

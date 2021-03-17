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
    public class CategoryController : ControllerBase
    {
        private readonly BooksContext _booksContext;

        public CategoryController(BooksContext booksContext)
        {
            _booksContext = booksContext;
        }

        [HttpPost]
        public ActionResult PostCategory(Category category)
        {
            _booksContext.Categories.Add(category);
            _booksContext.SaveChanges();
            return Ok("added");
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return _booksContext.Categories.ToList();
        }


    }
}

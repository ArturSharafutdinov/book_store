using book_store.IRepositories;
using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private BooksContext _booksContext;

       public CategoryRepository(BooksContext booksContext)
        {
            this._booksContext = booksContext;
        }

        public Category findById(int id)
        {
            return _booksContext.Categories.FirstOrDefault(cat => cat.categoryId == id);
        }

        public Category findByName(string name)
        {
           return _booksContext.Categories.FirstOrDefault(cat => cat.name == name);
        }
    }
}

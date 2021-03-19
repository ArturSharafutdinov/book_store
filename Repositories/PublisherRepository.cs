using book_store.IRepositories;
using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private BooksContext _booksContext;

        PublisherRepository(BooksContext booksContext)
        {
            this._booksContext = booksContext;
        }

        public Publisher findByName(string name)
        {
          return  _booksContext.Publishers.Find(name);
        }
    }
}

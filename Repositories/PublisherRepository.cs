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

        public PublisherRepository(BooksContext booksContext)
        {
            this._booksContext = booksContext;
        }

        public Publisher findById(int id)
        {
            return _booksContext.Publishers.FirstOrDefault(pub => pub.publisherId == id);
        }

        public Publisher findByName(string name)
        {
            return _booksContext.Publishers.FirstOrDefault(pub => pub.name == name);
        }
    }
}

using book_store.Models;
using book_store.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.IServices
{
    public interface IBookService
    {
        public void addBook(BookDto bookDto);

        public IEnumerable<Book> getAllBooks();

        public Book getBookById(int id);

        public void updateBook(Book book);

        public void removeBook(int id);
    }
}

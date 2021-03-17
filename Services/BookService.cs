using AutoMapper;
using book_store.IRepositories;
using book_store.IServices;
using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Services
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _bookRep;
        private readonly IMapper _mapper;
        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRep = bookRepository;
            _mapper = mapper;
        }


        public void addBook(Book book)
        {
            _bookRep.Create(book);
            _bookRep.Save();
        }

        public IEnumerable<Book> getAllBooks()
        {
            return _bookRep.GetAll();
        }

        public Book getBookById(int id)
        {
            return _bookRep.GetById(id);
        }

        public void updateBook(Book book)
        {
       
            _bookRep.Update(book);
            _bookRep.Save();
        }

        public void removeBook(int id)
        {
            _bookRep.Delete(id);
            _bookRep.Save();
        }


    }
}

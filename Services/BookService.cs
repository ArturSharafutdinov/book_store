using AutoMapper;
using book_store.IRepositories;
using book_store.IServices;
using book_store.Mappers;
using book_store.Models;
using book_store.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Services
{
    public class BookService : IBookService
    {

        private readonly IBookRepository _bookRep;
        private readonly ICategoryService _categoryService;
        private readonly IPublisherService _publisherService;


        public BookService(IBookRepository bookRepository, ICategoryService categoryService, IPublisherService publisherService)
        {
            _bookRep = bookRepository;
            _categoryService = categoryService;
            _publisherService = publisherService;
        }


        public void addBook(BookDto bookDto)
        {
            Category category = _categoryService.findByName(bookDto.categoryName);
            Publisher publisher = _publisherService.findByName(bookDto.publisherName);

            if (category == null)
            {
                category = new Category(bookDto.categoryName);
            }
            if (publisher == null)
            {
                publisher = new Publisher(bookDto.publisherName);
            }

            Book book = BookMapper.mapToEntity(bookDto, publisher, category);
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

        public bool reduceBook(OrderBookDto[] orderBookDtos)
        {
            foreach (OrderBookDto orderBook in orderBookDtos)
            {
                Book book = _bookRep.GetById(orderBook.bookId);
                book.kolvo -= orderBook.kolvo;
                _bookRep.Update(book);
                _bookRep.Save();
            }
            return true;
        }
    }
}

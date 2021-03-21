using book_store.IRepositories;
using book_store.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BooksContext db;
        public BookRepository(BooksContext booksContext)
        {
            db = booksContext;
        }

        public void Create(Book item)
        {
            db.Add(item);
        }

        public void Delete(int id)
        {
            db.Remove(db.Books.Find(id));
        }


        public Book GetById(int id)
        {
            return db.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Books.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Book item)
        {
            db.Books.Update(item);
            db.SaveChanges();
        }

        public bool Exists(int id)
        {
            return GetById(id) != null;
        }

        public Publisher GetPublisher(int id)
        {
            return db.Books.Include(p => p.publisher).FirstOrDefault(book => book.bookId == id).publisher;
        }

            public Category GetCategory(int id)
            {
                return db.Books.Include(p => p.category).FirstOrDefault(book => book.bookId == id).category;
            }
        }
    }

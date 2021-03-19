using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store
{
    public class DbInitializer
    {
        public static void Initialize(BooksContext context)
        {
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        name = "Цивилизация с нуля",
                        pages = 150,
                        price = 150.5,
                        image = "testImage",
                        author = "testAuthor",
                        publisher = new Publisher("firstPublisher"),
                        category = new Category("Художественная литература")

                    },
                   new Book
                   {
                       name = "Spring in Action",
                       pages = 1500,
                       price = 1500.5,
                       image = "testImage2",
                       author = "testAuthor2",
                       publisher = new Publisher("secondPublisher"),
                       category = new Category("Учебная литература")

                   },
                    new Book
                    {
                        name = "Энциклопедия",
                        pages = 120,
                        price = 1240.5,
                        image = "testImage3",
                        author = "testAuthor3",
                        publisher = new Publisher("thirdPublisher"),
                        category = new Category("Справочник")

                    }

                   ) ;
                context.SaveChanges();
            }

        }
    }
}

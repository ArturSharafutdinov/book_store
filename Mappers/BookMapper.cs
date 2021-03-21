using book_store.IServices;
using book_store.Models;
using book_store.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Mappers
{
    public class BookMapper
    {
     
        public static Book mapToEntity(BookDto bookDto, Publisher publisher, Category category)
        {
          

            return new Book(
                bookDto.name,
                bookDto.pages,
                bookDto.price,
                bookDto.image,
                bookDto.author,
                bookDto.kolvo,
                publisher,
                category
                );

        }

        public static BookDto mapToDto(Book book)
        {
            return new BookDto(
                book.bookId,
                book.name,
                book.pages,
                book.price,
                book.image,
                book.author,
                book.publisher.name,
                book.category.name,
                book.kolvo
                );
        }
    }
}

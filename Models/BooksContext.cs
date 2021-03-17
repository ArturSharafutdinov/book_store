using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class BooksContext : DbContext
    {
        
        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}

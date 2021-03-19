﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {

        public DbSet<Order> orders { get; set; }
        public DbSet<OrderBook> orderBooks { get; set; }

        public ApplicationContext(DbContextOptions options)
              : base(options)
        {
        }


    }
}

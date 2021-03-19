﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models.Dto
{
    public class BookDto
    {

        public string name { get; set; }

        public int pages { get; set; }

        public double price { get; set; }

        public string image { get; set; }

        public string author { get; set; }

        public string publisherName { get; set; }

        public string categoryName { get; set; }
    }
}

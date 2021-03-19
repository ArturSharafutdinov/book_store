using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class Category
    {

        public int categoryId { get; set; }
        public string name { get; set; }

        public Category(string name)
        {
            this.name = name;
        }

    }
}

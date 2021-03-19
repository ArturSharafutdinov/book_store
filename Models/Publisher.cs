using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class Publisher
    {

        public int publisherId { get; set; }
        public string name { get; set; }

       public Publisher(string name)
        {
            this.name = name;
        }
    }
}

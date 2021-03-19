using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Models
{
    public class User : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string mailing { get; set; }
        public List<Order> orders { get; set; }
    }
}

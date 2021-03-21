using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.IRepositories
{
    public interface IPublisherRepository
    {
        Publisher findByName(string name);

        Publisher findById(int id);
    }
}

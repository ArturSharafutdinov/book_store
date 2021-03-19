using book_store.IRepositories;
using book_store.IServices;
using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Services
{
    public class PublisherService : IPublisherService
    {

        private readonly IPublisherRepository _publisherRepository;

        public PublisherService(IPublisherRepository publisherRepository)
        {
            this._publisherRepository = publisherRepository;
        }

        public Publisher findByName(string name)
        {
            return _publisherRepository.findByName(name);
        }
    }
}

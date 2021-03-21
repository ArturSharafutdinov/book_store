using book_store.IRepositories;
using book_store.IServices;
using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public Category findByName(string name)
        {
            return this._categoryRepository.findByName(name);
        }

        public Category findById(int id)
        {
            return this._categoryRepository.findById(id);
        }

    }
}

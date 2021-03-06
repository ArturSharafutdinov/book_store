using book_store.IRepositories;
using book_store.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly ApplicationContext _appContext;

        public OrderRepository(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public void Create(Order item)
        {
            _appContext.Order.Add(item);
        }

        public void Delete(int id)
        {
            _appContext.Order.Remove(_appContext.Order.Find(id));
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        public User GetAllOrders(string userId)
        {
            return _appContext.Users.Where(u=>u.Id==userId).Include(u=>u.orders).ThenInclude(u=>u.order).FirstOrDefault();
        }

        public Order GetById(int id)
        {
            return _appContext.Order.Find(id);
        }

        public void Save()
        {
            _appContext.SaveChanges();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }
    }
}

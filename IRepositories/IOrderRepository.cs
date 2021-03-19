using book_store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_store.IRepositories
{
    public interface IOrderRepository
    {
            IEnumerable<Order> GetAll(); // получение всех объектов
            Order GetById(int id); // получение одного объекта по id
            void Create(Order item); // создание объекта
            void Update(Order item); // обновление объекта
            void Delete(int id); // удаление объекта по id
            void Save();  // сохранение изменений
            bool Exists(int id); // проверка на null

    }
}

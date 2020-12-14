using System;
using System.Collections.Generic;
using promotersapp.Models;

namespace promotersapp.Repositories
{
    public interface IRepository<T> where T : BaseEntity

    {
        IEnumerable<T> GetAll();
        T GetOne(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

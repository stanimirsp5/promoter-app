using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using promotersapp.Contexts;
using promotersapp.Models;

namespace promotersapp.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PromoterDbContext _context;
        protected DbSet<T> entities;

        public Repository(PromoterDbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("no context");
            }

            _context = context;
            entities = context.Set<T>();
        }

        public void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public T GetOne(int id)
        {
            return entities.SingleOrDefault(el => el.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
        }
    }
}

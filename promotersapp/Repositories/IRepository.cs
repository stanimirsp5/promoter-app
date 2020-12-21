using System.Linq;
using promotersapp.Models;

namespace promotersapp.Repositories
{
    public interface IRepository<T> where T : BaseEntity

    {
        IQueryable<T> GetAll();
        T GetOne(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

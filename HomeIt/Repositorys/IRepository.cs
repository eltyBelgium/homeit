using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorys
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> _entity { get;}
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
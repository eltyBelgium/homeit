using System.Collections.Generic;
using HomeIt.Models;

namespace HomeIt.Repositorys
{
    public interface IRepository<T> where T : BaseUtility
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
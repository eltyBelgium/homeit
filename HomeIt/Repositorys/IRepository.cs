using System;
using System.Collections.Generic;
using HomeIt.Models;

namespace HomeIt.Repositorys
{
    public interface IRepository<T> where T : BaseUtility
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool LogError(Exception e);
    }
}
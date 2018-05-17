using System;
using System.Collections.Generic;
using HomeIt.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeIt.Repositorys
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
using System;
using System.Collections.Generic;
using HomeIt.Db;
using HomeIt.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeIt.Repositorys
{
    public class UtilityRepository<T> : IRepository<T> where T: BaseUtility
    {

        private readonly DataContext _context;
        private DbSet<T> entities;
        string errorMessage = String.Empty;
        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
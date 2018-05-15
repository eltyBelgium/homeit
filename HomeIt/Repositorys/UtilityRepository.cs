using System;
using System.Collections.Generic;
using System.Linq;
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

        public UtilityRepository(DataContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
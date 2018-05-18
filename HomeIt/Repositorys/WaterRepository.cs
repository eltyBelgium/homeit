using System;
using System.Collections.Generic;
using System.Linq;
using HomeIt.Db;
using HomeIt.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeIt.Repositorys
{
    public class WaterRepository : IRepository<Water>
    {
        private DataContext _context;

        public DbSet<Water> _entity { get; } 

        public WaterRepository(DataContext context)
        {
            _context = context;
            _entity = context.Set<Water>();
        }
        public IEnumerable<Water> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public Water Get(long id)
        {
            return _entity.FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Water entity)
        {
            
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(Water entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Water entity)
        {
            var item = Get(entity.Id);
            _entity.Remove(item);
            _context.SaveChanges();
        }

       
    }
}
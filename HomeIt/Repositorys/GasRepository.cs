using System;
using System.Collections.Generic;
using System.Linq;
using HomeIt.Db;
using HomeIt.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeIt.Repositorys
{
    public class GasRepository : IRepository<Gas>
    {
        private DataContext _context;

        public DbSet<Gas> _entity { get; } 

        public GasRepository(DataContext context)
        {
            _context = context;
            _entity = context.Set<Gas>();
        }
        public IEnumerable<Gas> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public Gas Get(long id)
        {
            return _entity.FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Gas entity)
        {
            
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(Gas entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Gas entity)
        {
            var gas = Get(entity.Id);
            _entity.Remove(gas);
            _context.SaveChanges();
        }

       
    }
}
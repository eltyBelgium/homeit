using System.Collections.Generic;
using System.Linq;
using API.DB;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorys
{
    public class ElectricityRepository : IRepository<Electricity>
    {
        private DataContext _context;

        public DbSet<Electricity> _entity { get; } 

        public ElectricityRepository(DataContext context)
        {
            _context = context;
            _entity = context.Set<Electricity>();
        }
        public IEnumerable<Electricity> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public Electricity Get(long id)
        {
            return _entity.FirstOrDefault(e => e.Id == id);
        }

        public void Insert(Electricity entity)
        {
            
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
        }

        public void Update(Electricity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Electricity entity)
        {
            var electricity = Get(entity.Id);
            _entity.Remove(electricity);
            _context.SaveChanges();
        }

       
    }
}
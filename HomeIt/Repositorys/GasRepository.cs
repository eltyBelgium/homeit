using System;
using System.Collections.Generic;
using System.Linq;
using HomeIt.Db;
using HomeIt.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeIt.Repositorys
{
    public class GasRepository : IRepository<BaseUtility>
    {

        private readonly DataContext _context;

        public GasRepository()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            _context = context;
        }

        public IEnumerable<Gas> GetAll()
        {
            return _context.Gas.ToList();
        }
        public BaseUtility Get(long id)
        {
            return _context.Gas.FirstOrDefault(g => g.Id == id);
        }

        public bool Insert(BaseUtility entity)
        {
            if (entity == null)
                return false;

            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return LogError(e);
            }
        }

        public bool Update(BaseUtility entity)
        {
            if (entity == null)
                return false;

            try
            {
                _context.Update(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return LogError(e);
            }
        }

        public bool Delete(BaseUtility entity)
        {
            if (entity == null)
                return false;

            try
            {
                _context.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return LogError(e);
            }
        }

        public bool LogError(Exception e)
        {
            _context.Errors.Add(new Errors()
            {
                Message = e.Message,
                StackTrace = e.StackTrace,
                Timestamp = DateTime.Now
            });
            _context.SaveChanges();

            return false;
        }

        IEnumerable<BaseUtility> IRepository<BaseUtility>.GetAll()
        {
            throw new NotImplementedException();
        }

        
    }
}
using System;
using System.Linq;
using System.Threading.Tasks;
using LibraryCMS.Contexts;
using Microsoft.EntityFrameworkCore;

namespace LibraryCMS.Services
{
    public class DataService<T> : IDataService<T> where T : class
    {
        private readonly LibraryContext _context;
        private DbSet<T> _dbSet;
        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }
        
        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public T GetSingle(Func<T, bool> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        
        public DataService(LibraryContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        
    }
}
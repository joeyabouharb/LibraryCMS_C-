using System.Linq;
using System.Threading.Tasks;
using System;
namespace LibraryCMS.Services
{
    public interface IDataService<T>
    {
        IQueryable<T> GetAll();

        void Create(T entity);
        T GetSingle(Func<T, bool> predicate);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
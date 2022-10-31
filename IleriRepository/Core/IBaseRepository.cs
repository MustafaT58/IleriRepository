using Microsoft.EntityFrameworkCore;

namespace IleriRepository.Core
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> List();
        public T Find(int Id);
        public bool Update(T entity);
        public bool Delete(T entity);
        public bool Add(T entity);
        public DbSet<T> Set();
    }
}

using IleriRepository.Context;
using Microsoft.EntityFrameworkCore;

namespace IleriRepository.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        MyContext _db;
        public BaseRepository(MyContext db)
        {
            _db = db;
        }

        public T Find(int Id)
        {
            return Set().Find(Id);
        }
        public T Find(string Id)
        {
            return Set().Find(Id);
        }

        public List<T> List()
        {
            return Set().ToList();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }
        public bool Add(T entity)
        {
            try
            {
                Set().Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                Set().Remove(Find(Id));
                //var ent=Find(Id);
                //Set().Remove(ent);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(T entity)
        {
            try
            {
                Set().Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}

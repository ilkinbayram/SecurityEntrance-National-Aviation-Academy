using SecureEntrance.DesktopUI.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.EntityFramework
{
    public class Repository<T> : RepositorySingletonContext,IDataAccess<T> where T: class, new()
    {
        private DbSet<T> _objSet;
        public Repository()
        {
            _objSet = _context.Set<T>();
        }

        public int Delete(T obj)
        {
            var entity = _context.Entry(obj);
            entity.State = EntityState.Modified;
            return Save();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _objSet.FirstOrDefault(where);
        }

        public IQueryable<T> GetByQueryable(Expression<Func<T, bool>> where)
        {
            return _objSet.Where(where);
        }

        public int Insert(T obj)
        {
            var entity = _context.Entry(obj);
            entity.State = EntityState.Added;
            return Save();
        }

        public List<T> ListAll(Expression<Func<T, bool>> where)
        {
            return _objSet.Where(where).ToList();
        }

        public List<T> ListAll()
        {
            return _objSet.ToList();
        }

        public int PermanentlyDelete(T obj)
        {
            var entity = _context.Entry(obj);
            entity.State = EntityState.Deleted;
            return Save();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public int Update(T obj)
        {
            var entity = _context.Entry(obj);
            entity.State = EntityState.Modified;
            return Save();
        }
    }
}

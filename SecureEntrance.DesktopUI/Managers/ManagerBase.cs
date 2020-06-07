using SecureEntrance.DesktopUI.Abstract;
using SecureEntrance.DesktopUI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Managers
{
    public class ManagerBase<T> : IDataAccess<T> where T:class,new()
    {
        private Repository<T> _repo = new Repository<T>();
        public int Delete(T obj)
        {
            return _repo.Delete(obj);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return _repo.Get(where);
        }

        public IQueryable<T> GetByQueryable(Expression<Func<T, bool>> where)
        {
            return _repo.GetByQueryable(where);
        }

        public int Insert(T obj)
        {
            return _repo.Insert(obj);
        }

        public List<T> ListAll(Expression<Func<T, bool>> where)
        {
            return _repo.ListAll(where);
        }

        public List<T> ListAll()
        {
            return _repo.ListAll();
        }

        public int PermanentlyDelete(T obj)
        {
            return _repo.PermanentlyDelete(obj);
        }

        public int Save()
        {
            return _repo.Save();
        }

        public int Update(T obj)
        {
            return _repo.Update(obj);
        }
    }
}

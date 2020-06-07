using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Abstract
{
    public interface IDataAccess<T>
    {
        List<T> ListAll(Expression<Func<T, bool>> where);
        List<T> ListAll();
        T Get(Expression<Func<T, bool>> where);
        IQueryable<T> GetByQueryable(Expression<Func<T, bool>> where);
        int Insert(T obj);
        int Update(T obj);
        int Delete(T obj);
        int PermanentlyDelete(T obj);
        int Save();
    }
}

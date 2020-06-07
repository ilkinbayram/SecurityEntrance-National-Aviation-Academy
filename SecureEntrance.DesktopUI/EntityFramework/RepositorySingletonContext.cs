using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.EntityFramework
{
    public class RepositorySingletonContext
    {
        protected static SecureEntranceContext _context;
        private static object _lockSync = new object();

        public RepositorySingletonContext()
        {
            CreateDB();
        }

        private static SecureEntranceContext CreateDB()
        {
            if (_context == null)
            {
                lock (_lockSync)
                {
                    if (_context == null)
                    {
                        _context = new SecureEntranceContext();
                    }
                }
            }

            return _context;
        }
    }
}

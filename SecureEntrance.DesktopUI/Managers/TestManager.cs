using SecureEntrance.DesktopUI.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Managers
{
    public class TestManager
    {
        public TestManager()
        {
            SecureEntranceContext dbc = new SecureEntranceContext();
            dbc.Countries.ToList();
        }
    }
}

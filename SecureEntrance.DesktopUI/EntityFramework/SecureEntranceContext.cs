using SecureEntrance.DesktopUI.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.EntityFramework
{
    public class SecureEntranceContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<UnlawfulAct> UnlawfulActs { get; set; }
        public DbSet<LogProcess> LogProcesses { get; set; }
        public DbSet<LogSystem> LogSystems { get; set; }

        public SecureEntranceContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}

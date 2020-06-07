using SecureEntrance.DesktopUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.DesktopUI_Entities
{
    public static class CurrentModel
    {
        public static string SerieWorkerID { get; set; }
        public static int CountryID { get; set; }
        public static Passenger Passenger { get; set; }
        public static int GoingCountryID { get; set; }
    }
}

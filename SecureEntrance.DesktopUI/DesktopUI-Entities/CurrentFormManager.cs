using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureEntrance.DesktopUI.DesktopUI_Entities
{
    public static class CurrentFormManager
    {
        public static Form FormEntrance { get; set; }
        public static Form FormLogin { get; set; }
        public static Form FormWorkOn { get; set; }
        public static Form FormMessage { get; set; }
    }
}

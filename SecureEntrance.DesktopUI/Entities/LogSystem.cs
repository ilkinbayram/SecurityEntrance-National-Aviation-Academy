using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Entities
{
    [Table("LogSystems")]
    public class LogSystem : BaseEntity
    {
        public string SerieWorkerID { get; set; }
        public int CountryID { get; set; }
        public DateTime WorkerEntered { get; set; }
        public DateTime WorkerExited { get; set; }
    }
}

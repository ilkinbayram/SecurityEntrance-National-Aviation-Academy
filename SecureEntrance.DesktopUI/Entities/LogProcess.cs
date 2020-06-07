using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Entities
{
    [Table("LogProcesses")]
    public class LogProcess : BaseEntity
    {
        public string SerieWorkerID { get; set; }
        public string SeriePassengerID { get; set; }
        public int ActCode { get; set; }
        public DateTime ProcessDateTime { get; set; }
    }
}

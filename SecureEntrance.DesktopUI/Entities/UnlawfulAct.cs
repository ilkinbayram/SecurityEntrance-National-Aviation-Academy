using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Entities
{
    [Table("UnlawfulActs")]
    public class UnlawfulAct : BaseEntity
    {
        public int ActCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}

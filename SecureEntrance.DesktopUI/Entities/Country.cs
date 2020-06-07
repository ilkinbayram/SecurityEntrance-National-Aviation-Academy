using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Entities
{
    [Table("Countries")]
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }
        public virtual List<Passenger> Passengers { get; set; }
    }
}

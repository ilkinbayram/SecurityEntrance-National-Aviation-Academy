using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Entities
{
    [Table("Passengers")]
    public class Passenger : BaseEntity
    {
        public string IdentitySerie { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public bool Gender { get; set; }
        public int NowCountryID { get; set; }
        public virtual Country Nationality { get; set; }
        public virtual List<UnlawfulAct> UnlawfulActs { get; set; }
    }
}

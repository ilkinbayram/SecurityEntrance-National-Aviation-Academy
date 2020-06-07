using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Entities
{
    [Table("Workers")]
    public class Worker : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentitySerie { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string pswHelper { get; set; }
        public DateTime EnteredWork { get; set; }
        public DateTime ModifiedWork { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureEntrance.DesktopUI.Entities
{
    public abstract class BaseEntity
    {
        [Key,Required]
        public int ID { get; set; }
        public bool IsDeleted { get; set; }
    }
}

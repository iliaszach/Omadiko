using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Marble
    {
        public Marble()
        {
            Providers = new HashSet<Provider>();
            ApplicationUsers = new HashSet<ApplicationUser>();
        }
        
        public int MarbleId { get; set; }
        public string Name { get; set; }
        public string  Color { get; set; }
        public string MarbleDescription { get; set; }

        //Navigation Properties

        public virtual Country Country { get; set; }
        public virtual Photo Photo { get; set; }        
        public virtual ICollection<Provider> Providers { get; set; }
        public virtual ICollection<int> HelperProviders { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }


}

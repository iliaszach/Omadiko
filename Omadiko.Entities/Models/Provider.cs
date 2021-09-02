using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Provider
    {
        public Provider()
        {
            Marbles = new HashSet<Marble>();
            BusinessTypes = new HashSet<BusinessType>();
        }
        public int ProviderId { get; set; }        
        public string CompanyTitle { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyPhoto { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }

       


        //Navigation Property
        public virtual Location Location { get; set; }
        public virtual ICollection<Marble> Marbles { get; set; }
        public virtual ICollection<BusinessType> BusinessTypes { get; set; }
        public virtual ICollection<int> HelperMarbles { get; set; }
        public virtual ICollection<int> HelperBusinessTypes { get; set; }
    }
}

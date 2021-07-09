using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Provider
    {

        public int ProviderId { get; set; }
        public int LocationId { get; set; }
        public string CompanyTitle { get; set; }
        public string CompanyPhoto { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
        //Navigation Property
        public virtual Location Location { get; set; }
        public virtual ICollection<Marble> Marbles { get; set; }
    }
}

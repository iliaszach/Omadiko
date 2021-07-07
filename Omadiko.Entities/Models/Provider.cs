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
        public string CompanyTitle { get; set; }
        public string CompanyPhoto { get; set; }

        public string ContactPerson { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }








        //Navigation Properties



        public virtual Location Location { get; set; }  // i xsesi einai : (1) Provider <--------> Location (1)


        public virtual ICollection<BusinessType> BusinessTypes { get; set; }  //  i xsesi einai :  (*)Provider <-------> BusinessType(*)

        public virtual ICollection<Marble> Marbles { get; set; }  //  i xsesi einai :  (*)Provider <-------> Marble(*)
    }
}

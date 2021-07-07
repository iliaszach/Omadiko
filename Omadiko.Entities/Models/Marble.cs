using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Marble
    {
        public int MarbleId { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }



        //Navigation Properties



        public virtual ICollection<Provider> Providers { get; set; }  //  i xsesi einai :  (*)Provider <-------> Marble(*)

        public virtual Photo Photo { get; set; }  // thodoris: kai edo allaksa thn  xsesi einai :  (*)Photo <-------> Marble(*) se 1:1

        public virtual Location Location { get; set; }//<=================  DES TO   xsesi einai 1:1
    }
}

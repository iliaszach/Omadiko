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



        //Navigation Properties



        public virtual ICollection<Provider> Providers { get; set; }  //  i xsesi einai :  (*)Provider <-------> Marble(*)

        public virtual ICollection<Photo> Photos { get; set; }  // i xsesi einai :  (*)Photo <-------> Marble(*)




        public virtual Location Location { get; set; }//<=================  DES TO
    }
}

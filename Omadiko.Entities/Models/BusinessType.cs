using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class BusinessType
    {
        public int BusinessTypeId { get; set; }

        public string Factory { get; set; }

        public string Query { get; set; }


        public string Export { get; set; }

        public string Import { get; set; }


        //Navigation Properties



        public virtual ICollection<Provider> Providers { get; set; } //  //  i xsesi einai :  (*)Provider <-------> BusinessType(*)
    }
}

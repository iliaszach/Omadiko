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

        public List<string> Kind = new List<string>() { "Factory", "Quarry" };

        public int? ProviderId { get; set; }

        //public bool Factory { get; set; }
        //public bool Query { get; set; }
        //public bool Export { get; set; }        Ta grafo ayta os enallaktiki
        //public bool Import { get; set; }
        


       //Navigation Properties

    public virtual Provider Provider { get; set; } //  //  i xsesi einai :  (*)Provider <-------> BusinessType(*)
    }
}

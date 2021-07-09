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
        public string Kind { get; set; }
        //Navigation Properties
        public virtual ICollection<Provider> Providers { get; set; }
    }
}

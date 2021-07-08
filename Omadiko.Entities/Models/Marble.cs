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
        
        public int MarbleId { get; set; }
        public string Name { get; set; }
        public string  Color { get; set; }

        

        //Navigation Properties

        public virtual Photo Photo { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
    }
}

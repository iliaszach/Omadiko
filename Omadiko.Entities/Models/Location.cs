using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Location
    {
        [ForeignKey("Marble")]
        public int LocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        //Navigation Properties
        public virtual Marble Marble { get; set; }
    }
}

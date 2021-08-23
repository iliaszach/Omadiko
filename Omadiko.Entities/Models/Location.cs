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
        [ForeignKey("Provider")]
        public int LocationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }

        //Navigation Properties

        public virtual Provider Provider { get; set; }
    }
}

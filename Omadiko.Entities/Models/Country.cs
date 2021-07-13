using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }

        //Navidation properties
        public virtual ICollection<Marble> Marbles { get; set; }
    }
}

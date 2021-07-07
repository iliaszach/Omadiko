using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Photo
    {
        [ForeignKey("Marble")]
        public int PhotoId { get; set; }

        public string PhotoName { get; set; }


        public string Url { get; set; }




        //Navigation Properties


        public virtual Marble Marble { get; set; }  // thodoris: allazw tin sxesi apo (*)Photo <-------> Marble(*) se 1:1 h telos pantwn 0:1 oti katalavaini i xazomara
    }
}

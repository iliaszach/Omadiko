using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities.Models
{
    public class Photo
    {
        public int PhotosId { get; set; }

        public string PhotoName { get; set; }


        public string Url { get; set; }




        //Navigation Properties


        public Marble Marble { get; set; }  // thodoris: allazw tin sxesi apo (*)Photo <-------> Marble(*) se 1:1 h telos pantwn 0:1 oti katalavaini i xazomara
    }
}

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


        public virtual ICollection<Marble> Marbles { get; set; }  // i xsesi einai :  (*)Photo <-------> Marble(*)
    }
}

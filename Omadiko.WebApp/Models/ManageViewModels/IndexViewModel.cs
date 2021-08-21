using System.Collections.Generic;
using Omadiko.Entities.Models;

namespace Omadiko.WebApp.Models
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }        
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string  PhotoUrl { get; set; }
        public string Role { get; set; }


        public ICollection<Marble> Marbles { get; set; }

    }
}
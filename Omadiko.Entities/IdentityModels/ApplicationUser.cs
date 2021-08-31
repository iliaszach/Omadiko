using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Entities
{
    public class ApplicationUser : IdentityUser
    {

        // Here we add a byte to Save the user Profile Pictuer  
        public byte[] UserPhoto { get; set; }
        //We can find this class inside the In IdentityModels.cs in Model folder  






        public ApplicationUser()
        {
            Marbles = new HashSet<Marble>();
        }
        
        public string PhotoUrl { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public virtual ICollection<Marble> Marbles { get; set; }

    }
}

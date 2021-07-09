using Microsoft.AspNet.Identity.EntityFramework;
using Omadiko.Entities;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Database
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() :base("Sindesmos")
        {
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }
        public DbSet<Marble> Marbles { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Photo> Photos { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}

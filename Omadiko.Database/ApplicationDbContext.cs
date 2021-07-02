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

        }



        public DbSet<Provider> Providers { get; set; }

        public DbSet<Marble> Marbles { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<BusinessType> BusinessTypes { get; set; }

        public DbSet<Photo> Photos { get; set; }


        //public DbSet<Product> Products { get; set; }
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

    }
}

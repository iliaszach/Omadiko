namespace Omadiko.Database.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Omadiko.Entities;
    using Omadiko.Entities.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Omadiko.Database.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Omadiko.Database.ApplicationDbContext context)
        {
            //Seeding Products          
            Location l1 = new Location() { Country = "Italy", City = "Rome", Address = "Koloseo" };
            Location l2 = new Location() { Country = "France", City = "Paris", Address = "Panagia" };
            Location l3 = new Location() { Country = "England", City = "London", Address = "Palace" };
            Location l4 = new Location() { Country = "Greece", City = "Kastoria", Address = "Kafeneio" };
            Location l5 = new Location() { Country = "Greece", City = "Crete", Address = "Palaiochora" };
            Location l6 = new Location() { Country = "Greece", City = "Athens", Address = "Dexamenis" };
            context.Locations.AddOrUpdate(x => x.City, l1, l2, l3, l4, l5, l6);


            Provider p1 = new Provider() { CompanyTitle = "2E Marble", Phone="6949326800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto="photourl" };
            p1.Location = l1;
            Provider p2 = new Provider() { CompanyTitle = "2E Marìé",  Phone="6949314800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl" };
            p2.Location = l2;
            Provider p3 = new Provider() { CompanyTitle = "3D Stone Tile & Pavers",  Phone="6941626800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl" };
            p3.Location = l3;
            Provider p4 = new Provider() { CompanyTitle = "Turkish Marble ",  Phone="6949326840", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl" };
            p4.Location = l4;
            Provider p5 = new Provider() { CompanyTitle = "A Burslem and Son Ltd", Phone="6949327800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl" };
            p5.Location = l5;
            Provider p6 = new Provider() { CompanyTitle = "A2Z MARBLE AND TRAVERTINE",  Phone="6947126800", WebSite="www.cSharp.com", Email = "www", CompanyPhoto = "photourl" };
            p6.Location = l6;
            context.Providers.AddOrUpdate(x => new { x.CompanyTitle,x.CompanyPhoto,x.WebSite }, p1, p2, p3, p4, p5, p6);

            Marble m1 = new Marble() { Name = "ADRANOS ", Color = "White", Photo = new Photo() { PhotoName = "Marmaro1", Url = "www" }};
            m1.Providers = new List<Provider>() { p1, p2 };
            m1.Location = l1;
            Marble m2 = new Marble() { Name = "AFYON  ", Color = "White" , Photo = new Photo() { PhotoName = "Marmaro2", Url = "www" } };
            m2.Providers = new List<Provider>() { p3, p4 };
            m2.Location = l2;
            Marble m3 = new Marble() { Name = "AGIA MARINA ", Color = "SEMI-WHITE", Photo = new Photo() { PhotoName = "Marmaro3", Url = "www" } };
            m3.Providers = new List<Provider>() { p5, p6 };
            m3.Location = l3;
            Marble m4 = new Marble() { Name = "ALMERA  ", Color = "Pink", Photo = new Photo() { PhotoName = "Marmaro4", Url = "www" } };
            m4.Providers = new List<Provider>() { p1, p2 };
            m4.Location = l4;
            Marble m5 = new Marble() { Name = "ARABESCATO", Color = "ALTISSIMO", Photo = new Photo() { PhotoName = "Marmaro5", Url = "www" } };
            m5.Providers = new List<Provider>() { p3, p4 };
            m5.Location = l5;
            Marble m6 = new Marble() { Name = "AVAFESCATO ", Color = "CERVAIOLE", Photo = new Photo() { PhotoName = "Marmaro6", Url = "www" } };
            m6.Providers = new List<Provider>() { p5, p6 };
            m6.Location = l6;



            context.Marbles.AddOrUpdate(x => x.Name, m1, m2, m3, m4, m5, m6);
            context.SaveChanges();




            #region ImplB
            //var marbles = new List<Marble>
            //{
            //    new Marble { Name = "ADRANOS", Color = "White", Providers = new List<Provider>(){ p1, p2 } },
            //    new Marble { Name = "AFYON", Color = "White", Providers = new List<Provider>() { p3, p4 }  },
            //    new Marble { Name = "AGIA MARINA", Color = "SEMI-WHITE", Providers = new List<Provider>() { p5, p6 }    },
            //    new Marble { Name = "ALMERA", Color = "Pink", Providers = new List<Provider>() { p1, p2 }   },
            //    new Marble { Name = "ARABESCATO", Color = "ALTISSIMO", Providers = new List<Provider>() { p3, p4 }   },
            //    new Marble { Name = "AVAFESCATO ", Color = "CERVAIOLE", Providers = new List<Provider>() { p5, p6 }   }
            //};

            //marbles.ForEach(s => context.Marbles.AddOrUpdate(p => p.Name, s));

            //context.SaveChanges();
            //var photos = new List<Photo>
            //{
            //    new Photo { PhotoName = "Marmaro1", Url = "www" , MarbleId = marbles.FirstOrDefault(s => s.Name == "ADRANOS").MarbleId },
            //    new Photo { PhotoName = "Marmaro2", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "AFYON") },
            //    new Photo { PhotoName = "Marmaro3", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "AGIA MARINA") },
            //    new Photo { PhotoName = "Marmaro4", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "ALMERA") },
            //    new Photo { PhotoName = "Marmaro5", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "ARABESCATO") },
            //    new Photo { PhotoName = "Marmaro6", Url = "www" , Marble = marbles.FirstOrDefault(s => s.Name == "AVAFESCATO") },


            //};

            //photos.ForEach(s => context.Photos.AddOrUpdate(p => p.PhotoName, s));
            //context.SaveChanges();
            #endregion













            //Roles
            if (!context.Roles.Any(x => x.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };



                manager.Create(role);
            }


            var PasswordHash = new PasswordHasher();
            if (!context.Users.Any(x => x.UserName == "admin@admin.net"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.net",
                    Email = "admin@admin.net",
                    PasswordHash = PasswordHash.HashPassword("Admin1!")
                };



                manager.Create(user);
                manager.AddToRole(user.Id, "Admin");
            }





        }
    }
}

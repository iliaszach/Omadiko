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
           
            Provider p1 = new Provider() { CompanyTitle = "2E Marble", CompanyPhoto="Photo", Phone="6949326800", Website="www.cSharp.com", /*Location="Apo GoogleMaps",*/ };
            Provider p2 = new Provider() { CompanyTitle = "2E Marìé", CompanyPhoto="Photo", Phone="6949314800", Website="www.cSharp.com", /*Location="Apo GoogleMaps",*/ };
            Provider p3 = new Provider() { CompanyTitle = "3D Stone Tile & Pavers", CompanyPhoto="Photo", Phone="6941626800", Website="www.cSharp.com", /*Location="Apo GoogleMaps",*/ };
            Provider p4 = new Provider() { CompanyTitle = "Turkish Marble ", CompanyPhoto="Photo", Phone="6949326840", Website="www.cSharp.com", /*Location="Apo GoogleMaps",*/ };
            Provider p5 = new Provider() { CompanyTitle = "A Burslem and Son Ltd", CompanyPhoto="Photo", Phone="6949327800", Website="www.cSharp.com", /*Location="Apo GoogleMaps",*/ };
            Provider p6 = new Provider() { CompanyTitle = "A2Z MARBLE AND TRAVERTINE", CompanyPhoto="Photo", Phone="6947126800", Website="www.cSharp.com", /*Location="Apo GoogleMaps",*/ };
            context.Providers.AddOrUpdate(x => x.CompanyTitle, p1,p2,p3,p4,p5,p6);
            
            
            Marble m1 = new Marble() { Name = "ADRANOS ", Color="White"};
            m1.Providers = new List<Provider>() { p1, p2 };
            Marble m2 = new Marble() { Name = "AFYON  ", Color="White"};
            m2.Providers = new List<Provider>() { p3, p4 };
            Marble m3 = new Marble() { Name = "AGIA MARINA ", Color= "SEMI-WHITE" };
            m3.Providers = new List<Provider>() { p5, p6 };
            Marble m4 = new Marble() { Name = "ALMERA  ", Color= "Pink" };
            m4.Providers = new List<Provider>() { p1, p2 };
            Marble m5 = new Marble() { Name = "ARABESCATO", Color= "ALTISSIMO" };
            m5.Providers = new List<Provider>() { p3, p4 };
            Marble m6 = new Marble() { Name = "ARABESCATO ", Color = "CERVAIOLE" };
            m6.Providers = new List<Provider>() { p5, p6 };

            context.Marbles.AddOrUpdate(x => x.Name, m1, m2, m3, m4, m5, m6);
            
            
            
            context.SaveChanges();




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

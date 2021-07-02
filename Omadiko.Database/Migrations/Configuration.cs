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
            //Product p1 = new Product() { Name = "TurboX", Price = 550 };
            //Product p2 = new Product() { Name = "HP", Price = 200 };
            //Product p3 = new Product() { Name = "Samsung", Price = 300 };

            //context.Products.AddOrUpdate(x => new { x.Name }, p1, p2, p3);
            //context.SaveChanges();


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


            //========================================================


            //Student st1 = new Student { Name = "giorgos" };
            //Student st2 = new Student { Name = "giannis" };
            //Student st3 = new Student { Name = "kostas" };
            //Student st4 = new Student { Name = "maria" };
            //Student st5 = new Student { Name = "eleni" };

            //Course c1 = new Course { Title = "mathimatika" };

            //c1.Students = new List<Student>() { st1, st2 };
            //Course c2 = new Course { Title = "gymnastiki" };
            //c2.Students = new List<Student>() { st1, st2,st3 };
            //Course c3 = new Course { Title = "arxaia" };
            //c3.Students = new List<Student>() { st3 };
            //Course c4 = new Course { Title = "pliroforiki" };
            //c4.Students = new List<Student>() { st1, st2, st3, st4, st5 };


            //context.Students.AddOrUpdate(x => x.Name, st1, st2, st3, st4, st5);
            //context.Courses.AddOrUpdate(x => x.Title,c1,c2,c3,c4);

            //context.SaveChanges();




        }
    }
}

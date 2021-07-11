using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omadiko.Database;
using Omadiko.Entities.Models;
using System.Data.Entity;

namespace Omadiko.Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext db= new ApplicationDbContext())
            {
                #region b
                Location l15 = new Location() {Country="ELLADA",City="dadd",Address="dada" };
                db.Entry(l15).State = EntityState.Added;
                Provider p15 = new Provider();
                p15.CompanyTitle = "fafa";
                p15.CompanyPhoto = "fafa";
                p15.Email = "fafa";
                p15.WebSite = "fafa";
                p15.Phone = "fafa";
                var a = db.BusinessTypes.Find(1);
                p15.BusinessTypes = new List<BusinessType>() {a };
                var b = db.Marbles.Find(1);
                p15.Marbles = new List<Marble>() { b };
                p15.Location = l15;
                db.Entry(p15).State = EntityState.Added;
                db.SaveChanges();                                

                if (p15 is null)
                {
                    Console.WriteLine("null");
                    var amn =  db.BusinessTypes.ToList().Select(x => new
                    {
                        Value = x.BusinessTypeId.ToString(),
                        Text = x.Kind
                    });
                    foreach (var item in amn)
                    {
                        Console.WriteLine(item.Value);
                        Console.WriteLine(item.Text);
                    }
                }
                else
                {
                    var busTypeId = p15.BusinessTypes.Select(x => x.BusinessTypeId);
                    foreach (var item in busTypeId)
                    {
                        Console.WriteLine(item);
                    }                   
                    
                    var amn = db.BusinessTypes.ToList().Select(x => new 
                    {
                        Value = x.BusinessTypeId.ToString(),
                        Text = x.Kind,
                        Selected = busTypeId.Any(y => y == x.BusinessTypeId)
                    });

                    Console.WriteLine("ELSE");
                    foreach (var item in amn)
                    {
                        Console.WriteLine(item.Value);
                        Console.WriteLine(item.Text);
                        Console.WriteLine(item.Selected);
                    }
                }




                //var locations = db.Locations.ToList();
                //foreach (var item in locations)
                //{
                //    Console.WriteLine($"{item.Country,-15}");

                //}
                //var marbles = db.Marbles.ToList();
                //Console.WriteLine($"{"Marble Name",-15}{"Marble Photo",-15}{"Marble Country",-15}{"Marble Provider",-25}");
                //foreach (var item in marbles)
                //{
                //    Console.WriteLine($"{item.Name,-15}{item.Photo.PhotoName,-15}{item.Providers.First().CompanyTitle,-25}");

                //}               
                //var photos = db.Photos.ToList();
                //foreach (var item in photos)
                //{
                //    Console.WriteLine(item.PhotoName);
                //}
                #endregion

                //Location l12 = new Location() {Country="ELLADA",City="dadd",Address="dada" };
                //db.Entry(l12).State = EntityState.Added;
                //Provider p12 = new Provider();
                //p12.CompanyTitle = "fafa";
                //p12.CompanyPhoto = "fafa";
                //p12.Email = "fafa";
                //p12.WebSite = "fafa";
                //p12.Phone = "fafa";
                //var a = db.BusinessTypes.Find(1);
                //p12.BusinessTypes = new List<BusinessType>() {a };
                //var b = db.Marbles.Find(1);
                //p12.Marbles = new List<Marble>() { b };
                //p12.Location = l12;
                //db.Entry(p12).State = EntityState.Added;
                //db.SaveChanges();

                //Console.WriteLine(p12.Location.Address);



                //var providers = db.Providers.ToList();
                //Console.WriteLine("-----------------------");
                //Console.WriteLine($"{"Company Title",-15}{"Country",-25}{"Type of Business",-15}");
                //foreach (var item in providers)
                //{
                //    Console.WriteLine($"{item.CompanyTitle,-15}{item.Location?.Country,-25}");
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.WriteLine("Business Type");
                //    Console.ResetColor();
                //    foreach (var type in item.BusinessTypes)
                //    {
                //        Console.WriteLine(type.Kind);
                //    }
                //    Console.ForegroundColor = ConsoleColor.Green;
                //    Console.WriteLine("Marble");
                //    Console.ResetColor();
                //    foreach (var marble in item?.Marbles)
                //    {
                //        Console.WriteLine(marble.Name);
                //    }
                //    Console.WriteLine("================================");
                //}
                //Console.WriteLine("-----------------------");

            }


        }
    }
}

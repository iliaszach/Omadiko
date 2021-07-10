using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omadiko.Database;
using Omadiko.Entities.Models;

namespace Omadiko.Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationDbContext db= new ApplicationDbContext())
            {
                var locations = db.Locations.ToList();
                foreach (var item in locations)
                {
                    Console.WriteLine($"{item.Country,-15}");
                    
                }
                var marbles = db.Marbles.ToList();
                Console.WriteLine($"{"Marble Name",-15}{"Marble Photo",-15}{"Marble Country",-15}{"Marble Provider",-25}");
                foreach (var item in marbles)
                {
                    Console.WriteLine($"{item.Name,-15}{item.Photo.PhotoName,-15}{item.Providers.First().CompanyTitle,-25}");
                    
                }
                var providers = db.Providers.ToList();
                Console.WriteLine("-----------------------");
                Console.WriteLine($"{"Company Title",-15}{"Country",-25}{"Type of Business",-15}");
                foreach (var item in providers)
                {
                    Console.WriteLine($"{item.CompanyTitle, -15}{item.Location.Country, -25}{item.BusinessTypes.FirstOrDefault().Kind,-15}");                    
                }
                Console.WriteLine("-----------------------");
                var photos = db.Photos.ToList();
                foreach (var item in photos)
                {
                    Console.WriteLine(item.PhotoName);                    
                }
            }
 

        }
    }
}

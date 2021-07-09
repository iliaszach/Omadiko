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
                var marbles = db.Marbles.ToList();
                foreach (var item in marbles)
                {
                    Console.WriteLine($"{item.Name,-15}{item.Photo.PhotoName,-15}");
                    
                }
                var providers = db.Providers.ToList();
                Console.WriteLine("-----------------------");
                foreach (var item in providers)
                {
                    Console.WriteLine(item.CompanyTitle);                    
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

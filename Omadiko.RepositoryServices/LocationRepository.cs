using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    public class LocationRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();



        public List<Location> GetAll()
        {

            var locations = db.Locations.ToList();
            return locations;

        }

        public Location GetById(int? id)
        {
            return db.Locations.Find(id);
        }
        public Location GetWhereProvider(Provider provider, int? id)
        {
            return db.Locations.Where(x => x.Provider.ProviderId == provider.ProviderId).Single();
        }

        



    }
}

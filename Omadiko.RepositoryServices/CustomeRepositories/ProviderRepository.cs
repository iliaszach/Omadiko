using Omadiko.Database;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices.CustomRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        public ProviderRepository(ApplicationDbContext context) : base(context)
        {
        }
        public ApplicationDbContext DBContext
        {
            get
            {
                return Context as ApplicationDbContext;
            }
        }

     
        public void Delete(int id)
        {
            Provider provider = DBContext.Providers.Find(id);
            Location location = DBContext.Locations.Where(x => x.Provider.ProviderId == provider.ProviderId).Single();
            DBContext.Providers.Remove(provider);
            DBContext.Locations.Remove(location);
            DBContext.SaveChanges();
        }

        public void Create(Provider provider, Location Location, IEnumerable<int> Marbles, IEnumerable<int> BusinessTypes)
        {
            DBContext.Providers.Attach(provider);

            DBContext.Entry(provider).Collection("BusinessTypes").Load();
            provider.BusinessTypes.Clear();
            DBContext.Entry(provider).Collection("Marbles").Load();
            provider.Marbles.Clear();
            if (!(Marbles is null))
            {
                foreach (var id in Marbles)
                {
                    var marble = DBContext.Marbles.Find(id);
                    if (!(marble is null))
                    {
                        provider.Marbles.Add(marble);
                    }
                }
            }
            if (!(BusinessTypes is null))
            {
                foreach (var id in BusinessTypes)
                {
                    var type = DBContext.BusinessTypes.Find(id);
                    if (!(type is null))
                    {
                        provider.BusinessTypes.Add(type);
                    }
                }
            }

            DBContext.Entry(provider).State = EntityState.Added;
            DBContext.Entry(Location).State = EntityState.Added;
            provider.Location = Location;
            DBContext.SaveChanges();
        }
        
        public void Update(Provider provider, Location location, IEnumerable<int> Marbles, IEnumerable<int> BusinessTypes)
        {
            Location locationDeleted = DBContext.Locations.Where(x => x.Provider.ProviderId == provider.ProviderId).Single();
            DBContext.Locations.Remove(locationDeleted);
            DBContext.SaveChanges();
            var currentLoc = location;
            DBContext.Providers.Attach(provider);
            DBContext.Entry(location).State = EntityState.Deleted;
            DBContext.Locations.Attach(currentLoc);
            DBContext.Entry(currentLoc).State = EntityState.Added;
            provider.Location = currentLoc;
            DBContext.Entry(provider).State = EntityState.Modified;

            DBContext.Providers.Attach(provider);
            DBContext.Entry(provider).Collection("Marbles").Load();
            provider.Marbles.Clear();
            DBContext.SaveChanges();

            //*****************
            DBContext.Providers.Attach(provider);
            DBContext.Entry(provider).Collection("BusinessTypes").Load();
            provider.BusinessTypes.Clear();
            DBContext.SaveChanges();

            if (!(Marbles is null))
            {
                foreach (var id in Marbles)
                {
                    Marble marble = DBContext.Marbles.Find(id);
                    if (marble != null)
                    {
                        provider.Marbles.Add(marble);
                    }
                }
                DBContext.SaveChanges();
            }

            if (!(BusinessTypes is null))
            {
                foreach (var id in BusinessTypes)
                {
                    BusinessType businesstype = DBContext.BusinessTypes.Find(id);
                    if (businesstype != null)
                    {
                        provider.BusinessTypes.Add(businesstype);
                    }
                }
                DBContext.SaveChanges();
            }

            DBContext.Entry(provider).State = EntityState.Modified;
            DBContext.SaveChanges();
        }
        public IEnumerable<Provider> GetProviderByMarble(Marble marble)
        {
            return (List<Provider>)DBContext.Providers.ToList().Where(p => p.Marbles.Contains(marble)).ToList();
        }

        public IEnumerable<Provider> GetProviderByMarbleId(int id)
        {
            return (List<Provider>)DBContext.Providers.ToList().Where(p => p.Marbles.Any(m => m.MarbleId == id)).ToList();
        }


        public IEnumerable<Provider> GetProviderByCountry(Location location)
        {
            return (List<Provider>)DBContext.Providers.ToList().Where(l => l.Location.Country == location.Country).ToList();
        }

        public IEnumerable<Provider> GetProviderByLocationId(int id)
        {
            return (List<Provider>)DBContext.Providers.ToList().Where(l => l.Location.LocationId == id).ToList();
        }

              

        




    }
}

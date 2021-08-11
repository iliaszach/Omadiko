using Omadiko.Database;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices.InterfaceCustomRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    public class MarbleRepository:Repository<Marble>, IMarbleRepository
    {
        public MarbleRepository(ApplicationDbContext context):base(context)
        {

        }
        public ApplicationDbContext dbContext
        {
            get
            {
                return Context as ApplicationDbContext;
            }
        }       
        
        public void Create(Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected)
        {
            dbContext.Marbles.Attach(marble);

            dbContext.Entry(marble).Collection("Providers").Load();
            marble.Providers.Clear();
            if (!(providers is null))
            {
                foreach (var id in providers)
                {
                    var provider = dbContext.Providers.Find(id);
                    if (!(provider is null))
                    {
                        marble.Providers.Add(provider);
                    }
                }
            }

            dbContext.Entry(marble).State = EntityState.Added;

            var photo = dbContext.Photos.Find(PhotoSelected);
            if (!(photo is null))
            {
                dbContext.Entry(photo).State = EntityState.Added;
                marble.Photo = photo;
            }

            var country = dbContext.Countries.Find(CountrySelected);
            if (!(country is null))
            {
                dbContext.Entry(country).State = EntityState.Added;
                marble.Country = country;
            }
            dbContext.SaveChanges();
        }


        public void Update(Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected)
        {
            dbContext.Marbles.Attach(marble);

            dbContext.Entry(marble).Collection("Providers").Load();
            marble.Providers.Clear();
            if (!(providers is null))
            {
                foreach (var id in providers)
                {
                    var provider = dbContext.Providers.Find(id);
                    if (!(provider is null))
                    {
                        marble.Providers.Add(provider);
                    }
                }
            }
            dbContext.Entry(marble).Collection("Photos").Load();
            var photo = dbContext.Photos.Find(PhotoSelected);
            if (!(photo is null))
            {
                dbContext.Entry(photo).State = EntityState.Modified;
                marble.Photo = photo;
            }

            //var country = dbContext.Countries.Find(CountrySelected);
            //if (!(country is null))
            //{
            //    dbContext.Entry(country).State = EntityState.Modified;
            //    marble.Country = country;
            //}
            dbContext.Entry(marble).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Marble marble = dbContext.Marbles.Find(id);
            Photo photo = dbContext.Photos.Find(marble.Photo.PhotoId);
            dbContext.Marbles.Remove(marble);
            dbContext.Photos.Remove(photo);
            dbContext.SaveChanges();
        }

        public IEnumerable<Marble> GetMarbleByColor(string color)
        {
            return (List<Marble>)dbContext.Marbles.ToList().Where(x => x.Color == color);
        }

        public IEnumerable<Marble> GetMarbleByProvider(Provider provider)
        {
            return (List<Marble>)dbContext.Marbles.ToList().Where(c => c.Providers.Contains(provider)).ToList();
        }


        public IEnumerable<Marble> GetMarbleByProviderId(int id)
        {
            return (List<Marble>)dbContext.Marbles.ToList().Where(c => c.Providers.Any(i => i.ProviderId == id)).ToList();
        }

        public IEnumerable<Marble> GetMarbleByCountry(Location location)
        {
            return (List<Marble>)dbContext.Marbles.ToList();
        }

        public IEnumerable<Marble> GetMarbleByLocationId(int id)
        {
            return (List<Marble>)dbContext.Marbles.ToList();
        }     


    }
}

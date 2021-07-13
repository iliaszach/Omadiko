using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    public class MarbleRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<Marble> GetAll()
        {
            var marbles = db.Marbles.Include(m => m.Photo).Include(c=>c.Country);
            return marbles.ToList();

        }

        public Marble GetById(int? id)
        {
            return db.Marbles.Find(id);
        }

        public void Create(Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected)
        {
            db.Marbles.Attach(marble);

            db.Entry(marble).Collection("Providers").Load();
            marble.Providers.Clear();
            if (!(providers is null))
            {
                foreach (var id in providers)
                {
                    var provider = db.Providers.Find(id);
                    if (!(provider is null))
                    {
                        marble.Providers.Add(provider);
                    }
                }
            }

            db.Entry(marble).State = EntityState.Added;

            var photo = db.Photos.Find(PhotoSelected);
            if (!(photo is null))
            {
                db.Entry(photo).State = EntityState.Added;
                marble.Photo = photo;
            }

            var country = db.Countries.Find(CountrySelected);
            if (!(country is null))
            {
                db.Entry(country).State = EntityState.Added;
                marble.Country = country;
            }
            db.SaveChanges();
        }



        //elpizw na doulepsei otan ftiaxtoun oi Controllers
        public void Update(Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected)
        {
            db.Marbles.Attach(marble);

            db.Entry(marble).Collection("Providers").Load();
            marble.Providers.Clear();
            if (!(providers is null))
            {
                foreach (var id in providers)
                {
                    var provider = db.Providers.Find(id);
                    if (!(provider is null))
                    {
                        marble.Providers.Add(provider);
                    }
                }
            }

            var photo = db.Photos.Find(PhotoSelected);
            if (!(photo is null))
            {
                db.Entry(photo).State = EntityState.Modified;
                marble.Photo = photo;
            }

            //var country = db.Countries.Find(CountrySelected);
            //if (!(country is null))
            //{
            //    db.Entry(country).State = EntityState.Modified;
            //    marble.Country = country;
            //}
            db.Entry(marble).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Marble marble = db.Marbles.Find(id);
            Photo photo = db.Photos.Find(marble.Photo.PhotoId);
            db.Marbles.Remove(marble);
            db.Photos.Remove(photo);
            db.SaveChanges();
        }

        public List<Marble> GetMarbleByColor(string color)
        {
            return (List<Marble>)db.Marbles.ToList().Where(x => x.Color == color);
        }

        public List<Marble> GetMarbleByProvider(Provider provider)
        {
            return (List<Marble>)db.Marbles.ToList().Where(c => c.Providers.Contains(provider)).ToList();
        }


        public List<Marble> GetMarbleByProviderId(int id)
        {
            return (List<Marble>)db.Marbles.ToList().Where(c => c.Providers.Any(i => i.ProviderId == id)).ToList();
        }

        public List<Marble> GetMarbleByCountry(Location location)
        {
            return (List<Marble>)db.Marbles.ToList();
        }

        public List<Marble> GetMarbleByLocationId(int id)
        {
            return (List<Marble>)db.Marbles.ToList();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



    }
}

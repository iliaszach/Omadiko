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
    class ProviderRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public List<Provider> GetAll()
        {
            return db.Providers.ToList();
        }

        public Provider GetById(int? id)
        {
            return db.Providers.Find(id);
        }

        public void Create(Provider provider)
        {
            db.Entry(provider).State = EntityState.Added;
            db.SaveChanges();
        }


        //elpizw na doulepsei otan ftiaxtoun oi Controllers
        public void Update(Provider provider, IEnumerable<int> SelectedMarblesIds)
        {
            db.Providers.Attach(provider);
            db.Entry(provider).Collection("Marbles").Load();
            provider.Marbles.Clear();
            db.SaveChanges();

            if (!(SelectedMarblesIds is null))
            {
                foreach (var id in SelectedMarblesIds)
                {
                    Marble marble = db.Marbles.Find(id);
                    if (marble != null)
                    {
                        provider.Marbles.Add(marble);
                    }
                }
                db.SaveChanges();
            }

            db.Entry(provider).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Provider provider = db.Providers.Find(id);
            db.Providers.Remove(provider);
            db.SaveChanges();
        }

        public List<Provider> GetProviderByMarble(Marble marble)
        {
            return (List<Provider>)db.Providers.ToList().Where(p => p.Marbles.Contains(marble)).ToList();
        }

        public List<Provider> GetProviderByMarbleId(int id)
        {
            return (List<Provider>)db.Providers.ToList().Where(p => p.Marbles.Any(m => m.MarbleId == id)).ToList();
        }


        public List<Provider> GetProviderByCountry(Location location)
        {
            return (List<Provider>)db.Providers.ToList().Where(l => l.Location.Country == location.Country).ToList();
        }

        public List<Provider> GetProviderByLocationId(int id)
        {
            return (List<Provider>)db.Providers.ToList().Where(l => l.Location.LocationId == id).ToList();
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

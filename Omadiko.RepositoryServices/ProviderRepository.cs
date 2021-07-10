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
    public  class ProviderRepository
    {
        ApplicationDbContext db = new ApplicationDbContext();
        


        public List<Provider> GetAll()
        {

            var providers = db.Providers.Include(p => p.Location);
            return providers.ToList();
           
        }

        public Provider GetById(int? id)
        {
            return db.Providers.Find(id);
        }

        public void Create(Provider provider)
        {
            db.Providers.Attach(provider);
            db.Entry(provider).Collection("BusinessTypes").Load();
            provider.BusinessTypes.Clear();
            db.Entry(provider).Collection("Marbles").Load();
            provider.Marbles.Clear();


            db.Entry(provider).State = EntityState.Added;
            db.SaveChanges();
        }


        //elpizw na doulepsei otan ftiaxtoun oi Controllers
        public void Update(Provider provider, IEnumerable<int> SelectedMarblesIds, IEnumerable<int> SelectedBusinessTypesIds)
        {
            db.Providers.Attach(provider);
            db.Entry(provider).Collection("Marbles").Load();
            provider.Marbles.Clear();
            db.SaveChanges();

            //*****************
            db.Providers.Attach(provider);
            db.Entry(provider).Collection("BusinessTypes").Load();
            provider.BusinessTypes.Clear();
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

            if (!(SelectedBusinessTypesIds is null))
            {
                foreach (var id in SelectedBusinessTypesIds)
                {
                    BusinessType businesstype = db.BusinessTypes.Find(id);
                    if (businesstype != null)
                    {
                        provider.BusinessTypes.Add(businesstype);
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

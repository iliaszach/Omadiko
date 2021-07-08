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
    //class MarbleRepository
    //{
    //    ApplicationDbContext db = new ApplicationDbContext();

    //    public List<Marble> GetAll()
    //    {
    //        return db.Marbles.ToList();
    //    }

    //    public Marble GetById(int? id)
    //    {
    //        return db.Marbles.Find(id);
    //    }

    //    public void Create(Marble marble)
    //    {
    //        db.Entry(marble).State = EntityState.Added;
    //        db.SaveChanges();
    //    }


    //    //elpizw na doulepsei otan ftiaxtoun oi Controllers
    //    public void Update(Marble marble, IEnumerable<int> SelectedProvidersIds)
    //    {
    //        db.Marbles.Attach(marble);
    //        db.Entry(marble).Collection("Providers").Load();
    //        marble.Providers.Clear();
    //        db.SaveChanges();

    //        if (!(SelectedProvidersIds is null))
    //        {
    //            foreach (var id in SelectedProvidersIds)
    //            {
    //                Provider provider = db.Providers.Find(id);
    //                if (provider != null)
    //                {
    //                    marble.Providers.Add(provider);
    //                }
    //            }
    //            db.SaveChanges();
    //        }

    //        db.Entry(marble).State = EntityState.Modified;
    //        db.SaveChanges();
    //    }

    //    public void Delete(int id)
    //    {
    //        Marble marble = db.Marbles.Find(id);
    //        db.Marbles.Remove(marble);
    //        db.SaveChanges();
    //    }

    //    public List<Marble> GetMarbleByColor(string color)
    //    {
    //        return (List<Marble>)db.Marbles.ToList().Where(x => x.Color == color);
    //    }

    //    public List<Marble> GetMarbleByProvider(Provider provider)
    //    {
    //        return (List<Marble>)db.Marbles.ToList().Where(c => c.Providers.Contains(provider)).ToList();
    //    }


    //    public List<Marble> GetMarbleByProviderId(int id)
    //    {
    //        return (List<Marble>)db.Marbles.ToList().Where(c => c.Providers.Any(i => i.ProviderId == id)).ToList();
    //    }

    //    public List<Marble> GetMarbleByCountry(Location location)
    //    {
    //        return (List<Marble>)db.Marbles.ToList().Where(l => l.Location.Country == location.Country).ToList();
    //    }

    //    public List<Marble> GetMarbleByLocationId(int id)
    //    {
    //        return (List<Marble>)db.Marbles.ToList().Where(l => l.Location.LocationId == id).ToList();
    //    }


    //    private bool disposed = false;

    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!this.disposed)
    //        {
    //            if (disposing)
    //            {
    //                db.Dispose();
    //            }
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        Dispose(true);
    //        GC.SuppressFinalize(this);
    //    }



    //}
}

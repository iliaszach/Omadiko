using Omadiko.Database;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Omadiko.WebApi.Controllers
{
    public class ProvidersController : ApiController
    {
        //asynchronsly https://www.youtube.com/watch?v=hJ_V6pAm0PE&t=1201s
                
        private ApplicationDbContext db = new ApplicationDbContext();
       

        // GET: api/Providers
        public async Task<IHttpActionResult> GetProviders()
        {
            var providers = await db.Providers.ToListAsync();
            return Ok(
                providers.Select(x => new
                {
                    ProviderId = x.ProviderId,
                    CompanyTitle = x.CompanyTitle,
                    CompanyDescription = x.CompanyDescription,
                    CompanyPhoto = x.CompanyPhoto,
                    Phone = x.Phone,
                    WebSite = x.WebSite,
                    Email = x.Email,
                    Location = new { LocationId = x.Location.LocationId, Country = x.Location.Country },
                    Marbles = x.Marbles.Select(m => new { MarbleId=m.MarbleId, Name = m.Name }),
                    BusinessTypes = x.BusinessTypes.Select(m => new { BusinessTypeId = m.BusinessTypeId, Kind = m.Kind })
                })
                );
        }

        // GET: api/Providers/5
        [ResponseType(typeof(Provider))]
        public async Task<IHttpActionResult> GetProvider(int id)
        {
            try
            {
                Provider provider = await db.Providers.FindAsync(id);
                if (provider == null)
                {
                    return NotFound();
                }
                try
                {
                    return Ok(new 
                    {
                        ProviderId = provider.ProviderId,
                        CompanyTitle = provider.CompanyTitle,
                        CompanyDescription = provider.CompanyDescription,
                        CompanyPhoto = provider.CompanyPhoto,
                        Phone = provider.Phone,
                        WebSite = provider.WebSite,
                        Email = provider.Email,
                        Location = new { 
                            LocationId = provider.Location.LocationId, 
                            Country = provider.Location.Country,
                            City = provider.Location.City,
                            Address = provider.Location.Address,
                            Lat = provider.Location.Lat,
                            Lng = provider.Location.Lng
                        },
                        Marbles = provider.Marbles.Select(m => new 
                        { 
                            MarbleId=m.MarbleId, 
                            Name = m.Name 
                        }),
                        BusinessTypes = provider.BusinessTypes.Select(m => new 
                        { 
                            BusinessTypeId = m.BusinessTypeId, 
                            Kind = m.Kind 
                        })
                    });
                }
                catch (Exception Ex)
                {
                    return InternalServerError(Ex);
                }

            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }

        }

        // PUT: api/Providers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProvider(int id, Provider provider)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != provider.ProviderId)
            {
                return BadRequest();
            }
            //Location Updated
            try
            {
                //Store Location info
                //db.Providers.Attach(provider);
                Location la = db.Locations.Where(x => x.Provider.ProviderId == provider.ProviderId).Single();
                db.Providers.Attach(provider);
                db.Locations.Attach(provider.Location);
                provider.Location.Provider = provider;
                db.Entry(provider.Location).State = EntityState.Modified;
                await db.SaveChangesAsync();
                
               // db.Entry(provider.Location).State = EntityState.Modified;
              //  db.Entry(provider).State = EntityState.Modified;
                //db.Entry(NewLocation).State = EntityState.Added;
                
                //
                           
               


            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }
            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }
            //Collections BTypes + Marble
            try
            {
                
                var collectionBTypes = new List<int>();
                var collectionMarbles = new List<int>();

                foreach (var item in provider.BusinessTypes)
                {
                    var _id = item.BusinessTypeId;
                    collectionBTypes.Add(_id);

                }
                foreach (var item in provider.Marbles)
                {
                    var _id = item.MarbleId;
                    collectionMarbles.Add(_id);

                }
                provider.BusinessTypes.Clear();
                provider.Marbles.Clear();
                foreach (var _id in collectionBTypes)
                {
                    var bType = await db.BusinessTypes.FindAsync(_id);
                    if (!(bType is null))
                    {
                        provider.BusinessTypes.Add(bType);
                        db.Entry(bType).State = EntityState.Modified;
                    }
                }
                foreach (var _id in collectionMarbles)
                {
                    var marble = await db.Marbles.FindAsync(_id);
                    if (!(marble is null))
                    {
                        provider.Marbles.Add(marble);
                        db.Entry(marble).State = EntityState.Modified;
                    }
                }
                
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }
            try
            {
                db.Providers.Attach(provider);
                db.Entry(provider).State = EntityState.Modified;
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }

            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }

            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ProviderExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return StatusCode(HttpStatusCode.NoContent);
        }


        // POST: api/Providers
        [ResponseType(typeof(Provider))]
        public async Task<IHttpActionResult> PostProvider(Provider provider)
        {            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {                
                Location LocationProvider = provider.Location;              
                db.Locations.Attach(LocationProvider);
                db.Entry(LocationProvider).State = EntityState.Added;


                var collectionBTypes = new List<int>();
                var collectionMarbles = new List<int>();
                
                foreach (var item in provider.BusinessTypes)
                {                    
                    var id = item.BusinessTypeId;
                    collectionBTypes.Add(id);
                    
                }
                foreach (var item in provider.Marbles)
                {
                    var id = item.MarbleId;
                    collectionMarbles.Add(id);
                    
                }
                provider.BusinessTypes.Clear();
                provider.Marbles.Clear();
                foreach (var id in collectionBTypes)
                {
                    var bType = await db.BusinessTypes.FindAsync(id);
                    if (!(bType is null))
                    {
                        provider.BusinessTypes.Add(bType);
                        db.Entry(bType).State = EntityState.Modified;
                    }
                } 
                foreach (var id in collectionMarbles)
                {                    
                    var marble = await db.Marbles.FindAsync(id);
                    if (!(marble is null))
                    {
                        provider.Marbles.Add(marble);
                        db.Entry(marble).State = EntityState.Modified;
                    }
                }
                

            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }            

            try
            {
                db.Entry(provider).State = EntityState.Added;  
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }
            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }
            try
            {
                return Ok(new
                {
                    ProviderId = provider.ProviderId,
                    CompanyTitle = provider.CompanyTitle,
                    CompanyDescription = provider.CompanyDescription,
                    CompanyPhoto = provider.CompanyPhoto,
                    Phone = provider.Phone,
                    WebSite = provider.WebSite,
                    Email = provider.Email,
                    Location = new { Country = provider.Location.Country },
                    Marbles = provider.Marbles.Select(m => new { Name = m.Name }),
                    BusinessTypes = provider.BusinessTypes.Select(m => new { Kind = m.Kind })
                });
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }



            //return CreatedAtRoute("DefaultApi", new { id = provider.ProviderId }, provider);
        }

        // DELETE: api/Providers/5
        [ResponseType(typeof(Provider))]
        public async Task<IHttpActionResult> DeleteProvider(int id)
        {            
            Provider provider = await db.Providers.FindAsync(id);
            if (provider == null)
            {
                return NotFound();
            }

            Location LocationProvider = db.Locations.Where(x => x.Provider.ProviderId == id).Single();
            db.Entry(LocationProvider).State = EntityState.Deleted;            
            db.Entry(provider).Collection("BusinessTypes").Load();
            db.Entry(provider).Collection("Marbles").Load();
            provider.BusinessTypes.Clear();
            provider.Marbles.Clear();

            try
            {
                db.Entry(provider).State = EntityState.Deleted;
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }
            try
            {
                 await db.SaveChangesAsync();
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }

            return Ok("Deleted Successfully");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProviderExists(int id)
        {            
            return db.Providers.Count(e => e.ProviderId == id) > 0;
        }
    }
}

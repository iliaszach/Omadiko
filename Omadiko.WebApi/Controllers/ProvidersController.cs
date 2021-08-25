﻿using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
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
                    Location = new { Country = x.Location.Country },
                    Marbles = x.Marbles.Select(m => new { Name = m.Name }),
                    BusinessTypes = x.BusinessTypes.Select(m => new { Kind = m.Kind })
                })
                );
        }

        // GET: api/Providers/5
        [ResponseType(typeof(Provider))]
        public async Task<IHttpActionResult> GetProvider(int id)
        {
            Provider provider = await db.Providers.FindAsync(id);
            if (provider == null)
            {
                return NotFound();
            }
            return Ok(provider);
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


            db.Entry(provider).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProviderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

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
                db.Providers.Attach(provider);
                db.Entry(provider).Collection("BusinessTypes").Load();
                provider.BusinessTypes.Clear();
                db.Entry(provider).Collection("Marbles").Load();
                provider.Marbles.Clear();
            }
            catch (Exception Ex)
            {
                //return (IHttpActionResult)Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }
            

            //if (!(Marbles is null))
            //{
            //    foreach (var id in Marbles)
            //    {
            //        var marble = db.Marbles.Find(id);
            //        if (!(marble is null))
            //        {
            //            provider.Marbles.Add(marble);
            //        }
            //    }
            //}
            //if (!(BusinessTypes is null))
            //{
            //    foreach (var id in BusinessTypes)
            //    {
            //        var type = db.BusinessTypes.Find(id);
            //        if (!(type is null))
            //        {
            //            provider.BusinessTypes.Add(type);
            //        }
            //    }
            //}
            try
            {
                db.Entry(provider).State = EntityState.Added;  
            }
            catch (Exception Ex)
            {
                //return (IHttpActionResult)Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }
            try
            {
                await db.SaveChangesAsync();
            }
            catch (Exception Ex)
            {
                //return (IHttpActionResult)Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }            
            
            //return Ok(provider = new Provider
            //{
            //    ProviderId = provider.ProviderId,
            //    CompanyTitle = provider.CompanyTitle,
            //    CompanyDescription = provider.CompanyDescription,
            //    CompanyPhoto = provider.CompanyPhoto,
            //    Phone = provider.Phone,
            //    WebSite = provider.WebSite,
            //    Email = provider.Email,
            //    //Location = new Location { Country = provider.Location.Country }
            //});


            return CreatedAtRoute("DefaultApi", new { id = provider.ProviderId }, provider);
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
            // DBContext.Locations.Where(x => x.Provider.ProviderId == provider.ProviderId).Single();
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
                return (IHttpActionResult)Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
            }
            try
            {
                 await db.SaveChangesAsync();
            }
            catch (Exception Ex)
            {
                return (IHttpActionResult)Request.CreateErrorResponse(HttpStatusCode.BadRequest, Ex);
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
            db.Configuration.ProxyCreationEnabled = false;
            return db.Providers.Count(e => e.ProviderId == id) > 0;
        }
    }
}

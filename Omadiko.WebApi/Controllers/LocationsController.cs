using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Omadiko.Database;
using Omadiko.Entities.Models;

namespace Omadiko.WebApi.Controllers
{
    public class LocationsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Locations
        public async Task<IHttpActionResult> GetLocations()
        {
            var locations = await db.Locations.ToListAsync();
            return Ok(locations.Select(x => new
            {
                LocationId = x.LocationId,
                Country = x.Country,
                City = x.City,
                Address = x.Address,
                Lat = x.Lat,
                Lng = x.Lng,
                Providers =new {
                    ProviderId = x.Provider.ProviderId,
                    CompanyTitle = x.Provider.CompanyTitle 
                }
            }));
        }

        // GET: api/Locations/5
        [ResponseType(typeof(Location))]
        public async Task<IHttpActionResult> GetLocation(int id)
        {
            Location location = await db.Locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            return Ok(new {
                LocationId = location.LocationId,
                Country = location.Country,
                City = location.City,
                Address = location.Address,
                Lat = location.Lat,
                Lng = location.Lng,
                Provider = new { CompanyTitle = location.Provider.CompanyTitle }
            }) ;
        }

        // PUT: api/Locations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLocation(int id, Location location)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != location.LocationId)
            {
                return BadRequest();
            }

            db.Entry(location).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocationExists(id))
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

        // POST: api/Locations
        [ResponseType(typeof(Location))]
        public async Task<IHttpActionResult> PostLocation(Location location)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Locations.Add(location);


            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (LocationExists(location.LocationId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            //return CreatedAtRoute("DefaultApi", new { id = location.LocationId }, location);
            //return RedirectToRoute(new { controller = "Providers", action = "PostProvider" }/*, Location.Provider*/);
            return Redirect(Url.Link("DefaultApi", new { controller = "Providers", action = "PostProvider" })
);
        }

        // DELETE: api/Locations/5
        [ResponseType(typeof(Location))]
        public async Task<IHttpActionResult> DeleteLocation(int id)
        {
            Location location = await db.Locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }

            db.Locations.Remove(location);
            await db.SaveChangesAsync();

            return Ok(location);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocationExists(int id)
        {
            return db.Locations.Count(e => e.LocationId == id) > 0;
        }
    }
}
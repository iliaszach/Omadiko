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
        public IQueryable<Location> GetLocations()
        {
            return db.Locations;
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

            return Ok(location);
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

            //var collectionBTypes = new List<int>();
            //var collectionMarbles = new List<int>();
            //
            //foreach (var item in location.Provider.BusinessTypes)
            //{
            //    var id = item.BusinessTypeId;
            //    collectionBTypes.Add(id);
            //
            //}
            //foreach (var item in location.Provider.Marbles)
            //{
            //    var id = item.MarbleId;
            //    collectionMarbles.Add(id);
            //
            //}
            //location.Provider.BusinessTypes.Clear();
            //location.Provider.Marbles.Clear();
            //foreach (var id in collectionBTypes)
            //{
            //    var bType = await context.BusinessTypes.FindAsync(id);
            //    if (!(bType is null))
            //    {
            //        location.Provider.BusinessTypes.Add(bType);
            //        context.Entry(bType).State = EntityState.Modified;
            //    }
            //}
            //foreach (var id in collectionMarbles)
            //{
            //    var marble = await context.Marbles.FindAsync(id);
            //    if (!(marble is null))
            //    {
            //        location.Provider.Marbles.Add(marble);
            //        context.Entry(marble).State = EntityState.Modified;
            //    }
            //}


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
            return RedirectToRoute("Providers", "PostProvider");
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
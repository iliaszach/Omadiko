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
    public class MarblesController : ApiController
    {

        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: api/Marbles
        public async Task<IHttpActionResult> GetMarbles()
        {
            var marbles = await db.Marbles.ToListAsync();
            return Ok(
                marbles.Select(x => new
                {
                    MarbleId = x.MarbleId,
                    Name = x.Name,
                    MarbleDescription = x.MarbleDescription,
                    Photo = x.Photo,
                    Color = x.Color,
                    Country = x.Country,
                    Providers = x.Providers.Select(m => new { ProviderId = m.ProviderId, CompanyTitle = m.CompanyTitle })
                })
                );
        }

        // GET: api/Marbles/5
        [ResponseType(typeof(Marble))]
        public async Task<IHttpActionResult> GetMarble(int id)
        {
            try
            {
                Marble marble = await db.Marbles.FindAsync(id);
                if (marble == null)
                {
                    return NotFound();
                }
                try
                {
                    return Ok(new
                    {
                        MarbleId = marble.MarbleId,
                        Name = marble.Name,
                        MarbleDescription = marble.MarbleDescription,
                        Photo = marble.Photo,
                        Color = marble.Color,
                        Country = marble.Country,
                        Providers = marble.Providers.Select(m => new { ProviderId = m.ProviderId, CompanyTitle = m.CompanyTitle })
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

        // PUT: api/Marbles/5
        [ResponseType(typeof(void))]
        //[Route("api/marbles/{paramOne}/{paramTwo}/{paramThree}")]
        public async Task<IHttpActionResult> PutProvider(int id, Marble marble)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marble.MarbleId)
            {
                return BadRequest();
            }
            try
            {
                db.Marbles.Attach(marble);
                var providers = db.Providers.ToList();

                var collectionProviders = new List<int>();

                foreach (var item in marble.HelperProviders)
                {
                    collectionProviders.Add(item);
                }

                db.Entry(marble).Collection("Providers").Load();

                marble.Providers.Clear();

                db.Entry(marble).State = EntityState.Modified;
                await db.SaveChangesAsync();


                foreach (var _id in collectionProviders)
                {
                    var provider = db.Providers.Where(x => x.ProviderId == _id).Single();
                    marble.Providers.Add(provider);
                    db.Entry(provider).State = EntityState.Modified;
                }
                await db.SaveChangesAsync();
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
            return StatusCode(HttpStatusCode.NoContent);
        }


        // POST: api/Marbles
        [ResponseType(typeof(Marble))]
        public async Task<IHttpActionResult> PostMarble(Marble marble)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {

                var collectionProviders = new List<int>();

                foreach (var item in marble.Providers)
                {
                    var id = item.ProviderId;
                    collectionProviders.Add(id);

                }
                marble.Providers.Clear();
                foreach (var id in collectionProviders)
                {
                    var provider = await db.Providers.FindAsync(id);
                    if (!(provider is null))
                    {
                        marble.Providers.Add(provider);
                        db.Entry(provider).State = EntityState.Modified;
                    }
                }


            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }

            try
            {
                db.Entry(marble).State = EntityState.Added;
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
                    MarbleId = marble.MarbleId,
                    Name = marble.Name,
                    MarbleDescription = marble.MarbleDescription,
                    Photo = marble.Photo,
                    Color = marble.Color,
                    Country = marble.Country,
                    Providers = marble.Providers.Select(m => new { ProviderId = m.ProviderId, CompanyTitle = m.CompanyTitle })
                });
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }
        }

        // DELETE: api/Marbles/5
        [ResponseType(typeof(Marble))]
        public async Task<IHttpActionResult> DeleteProvider(int id)
        {
            Marble marble= await db.Marbles.FindAsync(id);
            if (marble == null)
            {
                return NotFound();
            }

            db.Entry(marble).Collection("Providers").Load();
            marble.Providers.Clear();


            try
            {
                db.Entry(marble).State = EntityState.Deleted;
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

        private bool MarbleExists(int id)
        {
            return db.Marbles.Count(e => e.MarbleId == id) > 0;
        }
    }
}

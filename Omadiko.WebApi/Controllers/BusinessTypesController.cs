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
    public class BusinessTypesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/BusinessTypes
        public async Task<IHttpActionResult> GetBusinessTypes()
        {
            try
            {
                var bTypes = await db.BusinessTypes.ToListAsync();
                return Ok(bTypes.Select(x => new
                {
                    BusinessTypeId = x.BusinessTypeId,
                    Kind = x.Kind,
                    Providers = x.Providers.Select(p => new { CompanyTitle = p.CompanyTitle })
                }
                ));
            }
            catch (Exception Ex)
            {
                return InternalServerError(Ex);
            }

        }

        // GET: api/BusinessTypes/5
        [ResponseType(typeof(BusinessType))]
        public async Task<IHttpActionResult> GetBusinessType(int id)
        {
            try
            {
                BusinessType businessType = await db.BusinessTypes.FindAsync(id);
                if (businessType == null)
                {
                    return NotFound();
                }
                try
                {
                    return Ok(new
                    {
                        BusinessTypeId = businessType.BusinessTypeId,
                        Kind = businessType.Kind,
                        Providers = businessType.Providers.Select(p => new { CompanyTitle = p.CompanyTitle })
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

        // PUT: api/BusinessTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBusinessType(int id, BusinessType businessType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != businessType.BusinessTypeId)
            {
                return BadRequest();
            }
            db.Entry(businessType).Collection("Providers").Load();            
            db.Entry(businessType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessTypeExists(id))
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

        // POST: api/BusinessTypes
        [ResponseType(typeof(BusinessType))]
        public async Task<IHttpActionResult> PostBusinessType(BusinessType businessType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BusinessTypes.Add(businessType);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = businessType.BusinessTypeId }, businessType);
        }

        // DELETE: api/BusinessTypes/5
        [ResponseType(typeof(BusinessType))]
        public async Task<IHttpActionResult> DeleteBusinessType(int id)
        {
            BusinessType businessType = await db.BusinessTypes.FindAsync(id);
            if (businessType == null)
            {
                return NotFound();
            }

            db.BusinessTypes.Remove(businessType);
            await db.SaveChangesAsync();

            return Ok(businessType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BusinessTypeExists(int id)
        {
            return db.BusinessTypes.Count(e => e.BusinessTypeId == id) > 0;
        }
    }
}
﻿using System;
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
    public class MarblesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Marbles
        public IHttpActionResult GetMarbles()
        {
           
            var marble = db.Marbles.ToList();
            return Ok(
                marble.Select(x => new
                {
                    MarbleId = x.MarbleId,
                    Name = x.Name,
                    Color = x.Color,
                    Country = x.Country,
                    Photo = x.Photo,
                    Providers = x.Providers.Select(p =>new {p.CompanyTitle })
                })
                );
        }

        // GET: api/Marbles/5
        [ResponseType(typeof(Marble))]
        public async Task<IHttpActionResult> GetMarble(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            Marble marble = await db.Marbles.FindAsync(id);
            if (marble == null)
            {
                return NotFound();
            }

            return Ok(marble);
        }

        // PUT: api/Marbles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMarble(int id, Marble marble)
        {
            db.Configuration.ProxyCreationEnabled = false;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != marble.MarbleId)
            {
                return BadRequest();
            }

            db.Entry(marble).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarbleExists(id))
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

        // POST: api/Marbles
        [ResponseType(typeof(Marble))]
        public async Task<IHttpActionResult> PostMarble(Marble marble)
        {
            db.Configuration.ProxyCreationEnabled = false;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Marbles.Add(marble);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = marble.MarbleId }, marble);
        }

        // DELETE: api/Marbles/5
        [ResponseType(typeof(Marble))]
        public async Task<IHttpActionResult> DeleteMarble(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;
            Marble marble = await db.Marbles.FindAsync(id);
            if (marble == null)
            {
                return NotFound();
            }

            db.Marbles.Remove(marble);
            await db.SaveChangesAsync();

            return Ok(marble);
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
            db.Configuration.ProxyCreationEnabled = false;
            return db.Marbles.Count(e => e.MarbleId == id) > 0;
        }
    }
}
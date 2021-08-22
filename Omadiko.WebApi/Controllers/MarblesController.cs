using Omadiko.Database;
using Omadiko.Entities;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Omadiko.WebApi.Controllers
{
    public class MarblesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        

        //private UnitOfWork unitOfWork = new UnitOfWork(new ApplicationDbContext());
        //GET api/marbles
        
        public IQueryable<Marble> Get()
        {
          return db.Marbles;
        }

        // GET: api/marble/5
        [ResponseType(typeof(Marble))]
        public IHttpActionResult GetProduct(int id)
        {
            Marble marble = db.Marbles.Find(id);
            if (marble == null)
            {
                return NotFound();
            }

            return Ok(marble);
        }

        //GET api/marble/1
        //public Marble Get(int id)
        //{
        //    return db.Marbles.FirstOrDefault(m => m.MarbleId == id);
        //}
    }
}

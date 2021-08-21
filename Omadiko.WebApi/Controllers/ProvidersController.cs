using Omadiko.Database;
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
    public class ProvidersController : ApiController
    {
        //Θοδωρή χρησιμοποίησε το project LastDance ή api dance , κάπως έτσι
        
        private ApplicationDbContext db = new ApplicationDbContext();        
        // GET: api/Providers
        public IHttpActionResult GetProviders()
        {            
            return Ok(db.Providers.ToList().Select(x => x.CompanyTitle ));
        }

        // GET: api/Providers/5        
        public IHttpActionResult GetProduct(int id)
        {
            Provider provider = db.Providers.Find(id);
            if (provider == null)
            {
                return NotFound();
            }

            return Ok(provider);
        }
    }
}

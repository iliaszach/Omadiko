using Omadiko.RepositoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class DashboardController : Controller
    {
        private ProviderRepository providerRepository = new ProviderRepository();
        
        // GET: Dashboard
        public ActionResult Index()
        {
            var providers = providerRepository.GetAll();
            return View(providers);
        }
    }
}
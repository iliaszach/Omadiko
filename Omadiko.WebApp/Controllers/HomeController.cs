using Omadiko.Database;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices.DataAccess;
using Omadiko.WebApp.Models;
using Omadiko.WebApp.Models.AccountViewModels;
using Omadiko.WebApp.Models.MarbleProviderViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ApplicationDbContext());

        public ActionResult Index()
        {
            var marbles = unitOfWork.Marbles.GetAll();

            var providers = unitOfWork.Providers.GetAll();

            var viewModel = new MarbleProviderVM
            {
                Marbles = (List<Marble>)marbles,
                Providers = (List<Provider>)providers
            };

            return View(viewModel);
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }
    }
}
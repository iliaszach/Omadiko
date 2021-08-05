using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Omadiko.Database;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices;
using Omadiko.WebApp.ViewModels;
using Omadiko.RepositoryServices.DataAccess;

namespace Omadiko.WebApp.Controllers
{
    public class ProviderController : Controller
    {   
        private UnitOfWork unitOfWork = new UnitOfWork(new ApplicationDbContext());


        // GET: Provider
        public ActionResult Index()
        {            
            var providers = unitOfWork.Providers.GetAll();
            return View(providers);
        }

        // GET: Provider/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = unitOfWork.Providers.GetById(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        // GET: Provider/Create
        public ActionResult Create()
        {
            ProviderCreateViewModel vm = new ProviderCreateViewModel();
            return View(vm);
        }

        // POST: Provider/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProviderId,CompanyTitle,CompanyPhoto,Phone,WebSite,Email")] Provider provider, Location location, IEnumerable<int> Marbles, IEnumerable<int> BusinessTypes)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Providers.Create(provider, location, Marbles, BusinessTypes);                
                return RedirectToAction("Index");
            }

            ProviderCreateViewModel vm = new ProviderCreateViewModel();
            return View(provider);
        }



        // GET: Provider/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = unitOfWork.Providers.GetById(id);
            if (provider == null)
            {
                return HttpNotFound();
            }

            var location = unitOfWork.Locations.GetWhereProvider(provider, id);
            
            if (location == null)
            {
                return HttpNotFound();
            }
            ProviderEditViewModel vm = new ProviderEditViewModel(provider, location);
            return View(vm);
        }




        // POST: Provider/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProviderId,CompanyTitle,CompanyPhoto,Phone,WebSite,Email,LocationId")] Provider provider, Location location, IEnumerable<int> SelectedMarble, IEnumerable<int> SelectedBusinessTypes)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.Providers.Update(provider, location, SelectedMarble, SelectedBusinessTypes);             
                return RedirectToAction("Index");
            }
            ProviderEditViewModel vm = new ProviderEditViewModel(provider, location);
            return View(provider);
        }



        // GET: Provider/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = unitOfWork.Providers.GetById(id);
            var location = unitOfWork.Locations.GetWhereProvider(provider, id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        // POST: Provider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {           
            unitOfWork.Providers.Delete(id);
            return RedirectToAction("Index");
        }

        //show one provider details
        public ActionResult Provider_Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = unitOfWork.Providers.GetById(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }



        public ActionResult ShowAllProviders()
        {
            var providers = unitOfWork.Providers.GetAll();
            return View(providers);
        }






        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }





}

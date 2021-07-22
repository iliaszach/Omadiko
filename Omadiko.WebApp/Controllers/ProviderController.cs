﻿using System;
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

namespace Omadiko.WebApp.Controllers
{
    public class ProviderController : Controller
    {  
        //private ApplicationDbContext db = new ApplicationDbContext();
        private ProviderRepository repoProvider = new ProviderRepository();
        private LocationRepository repoLocation = new LocationRepository();


        // GET: Provider
        public ActionResult Index()
        {            
            var providers = repoProvider.GetAll();
            return View(providers);
        }

        // GET: Provider/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = repoProvider.GetById(id);
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
                repoProvider.Create(provider, location, Marbles, BusinessTypes);                
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
            Provider provider = repoProvider.GetById(id);
            if (provider == null)
            {
                return HttpNotFound();
            }

            var location = repoLocation.GetWhereProvider(provider, id);
            
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
                repoProvider.Update(provider, location, SelectedMarble, SelectedBusinessTypes);             
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
            Provider provider = repoProvider.GetById(id);
            var location = repoLocation.GetWhereProvider(provider, id);
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
            repoProvider.Delete(id);
            return RedirectToAction("Index");
        }

        //show one provider details
        public ActionResult Provider_Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = repoProvider.GetById(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }










        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repoProvider.Dispose();
            }
            base.Dispose(disposing);
        }
    }





}

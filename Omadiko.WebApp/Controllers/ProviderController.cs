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

namespace Omadiko.WebApp.Controllers
{
    public class ProviderController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private ProviderRepository repo = new ProviderRepository();



        // GET: Provider
        public ActionResult Index()
        {
             

            var marbles = repo.GetAll();
            return View(marbles);


        }





        // GET: Provider/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = repo.GetById(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }




        // GET: Provider/Create
        public ActionResult Create()
        {
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Country");
            return View();
        }




        // POST: Provider/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProviderId,LocationId,CompanyTitle,CompanyPhoto,Phone,WebSite,Email")] Provider provider)
        {
            if (ModelState.IsValid)
            {
                repo.Create(provider);
                return RedirectToAction("Index");
            }

            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Country", provider.LocationId);
            return View(provider);
        }






        // GET: Provider/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = repo.GetById(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Country", provider.LocationId);
            return View(provider);
        }





        // POST: Provider/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProviderId,LocationId,CompanyTitle,CompanyPhoto,Phone,WebSite,Email")] Provider provider, IEnumerable<int> SelectedMarblesIds, IEnumerable<int> SelectedBusinessTypesIds)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(provider).State = EntityState.Modified;
                // db.SaveChanges();
                repo.Update(provider, SelectedMarblesIds, SelectedBusinessTypesIds);
                return RedirectToAction("Index");
            }
            ViewBag.LocationId = new SelectList(db.Locations, "LocationId", "Country", provider.LocationId);
            return View(provider);
        }




        // GET: Provider/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = repo.GetById(id);
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
            //Provider provider = db.Providers.Find(id);
            //db.Providers.Remove(provider);
            //db.SaveChanges();
            repo.Delete(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

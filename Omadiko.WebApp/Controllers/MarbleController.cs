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
    public class MarbleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private MarbleRepository repo = new MarbleRepository();




        // GET: Marble
        public ActionResult Index()
        {
            var marbles = repo.GetAll();
            return View(marbles);


           
        }





        // GET: Marble/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marble marble = repo.GetById(id);
            if (marble == null)
            {
                return HttpNotFound();
            }
            return View(marble);
        }




        // GET: Marble/Create
        public ActionResult Create()
        {
            ViewBag.MarbleId = new SelectList(db.Locations, "LocationId", "Country");
            ViewBag.MarbleId = new SelectList(db.Photos, "PhotoId", "PhotoName");
            return View();
        }





        // POST: Marble/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarbleId,Name,Color")] Marble marble)
        {
            if (ModelState.IsValid)
            {
                
                repo.Create(marble);
                return RedirectToAction("Index");
            }

            ViewBag.MarbleId = new SelectList(db.Locations, "LocationId", "Country", marble.MarbleId);
            ViewBag.MarbleId = new SelectList(db.Photos, "PhotoId", "PhotoName", marble.MarbleId);
            return View(marble);
        }

        // GET: Marble/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marble marble = repo.GetById(id);
            if (marble == null)
            {
                return HttpNotFound();
            }
            ViewBag.MarbleId = new SelectList(db.Locations, "LocationId", "Country", marble.MarbleId);
            ViewBag.MarbleId = new SelectList(db.Photos, "PhotoId", "PhotoName", marble.MarbleId);
            return View(marble);
        }

        // POST: Marble/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarbleId,Name,Color")] Marble marble, IEnumerable<int> SelectedProvidersIds)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(marble).State = EntityState.Modified;
                // db.SaveChanges();
                repo.Update(marble, SelectedProvidersIds);
                return RedirectToAction("Index");
            }
            ViewBag.MarbleId = new SelectList(db.Locations, "LocationId", "Country", marble.MarbleId);
            ViewBag.MarbleId = new SelectList(db.Photos, "PhotoId", "PhotoName", marble.MarbleId);
            return View(marble);
        }

        // GET: Marble/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marble marble = repo.GetById(id);
            if (marble == null)
            {
                return HttpNotFound();
            }
            return View(marble);
        }






        // POST: Marble/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // Marble marble = db.Marbles.Find(id);
            // db.Marbles.Remove(marble);
            // db.SaveChanges();
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

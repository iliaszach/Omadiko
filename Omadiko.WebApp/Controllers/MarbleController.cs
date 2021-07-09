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

namespace Omadiko.WebApp.Controllers
{
    public class MarbleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Marble
        public ActionResult Index()
        {
            var marbles = db.Marbles.Include(m => m.Photo);
            return View(marbles.ToList());
        }

        // GET: Marble/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marble marble = db.Marbles.Find(id);
            if (marble == null)
            {
                return HttpNotFound();
            }
            return View(marble);
        }

        // GET: Marble/Create
        public ActionResult Create()
        {
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
                db.Marbles.Add(marble);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

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
            Marble marble = db.Marbles.Find(id);
            if (marble == null)
            {
                return HttpNotFound();
            }
            ViewBag.MarbleId = new SelectList(db.Photos, "PhotoId", "PhotoName", marble.MarbleId);
            return View(marble);
        }

        // POST: Marble/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarbleId,Name,Color")] Marble marble)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marble).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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
            Marble marble = db.Marbles.Find(id);
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
            Marble marble = db.Marbles.Find(id);
            db.Marbles.Remove(marble);
            db.SaveChanges();
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

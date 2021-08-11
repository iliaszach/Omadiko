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
            ViewBag.RelativeMarble = repo.GetAll().Where(x => x.Color == marble.Color).Where(x=>x.MarbleId != marble.MarbleId);
            if (marble == null)
            {
                return HttpNotFound();
            }
            return View(marble);
        }

        // GET: Marble/Create
        public ActionResult Create()
        {
            MarbleCreateViewModel vm = new MarbleCreateViewModel();
            return View(vm);
        }


        // POST: Marble/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarbleId,Name,Color")] Marble marble, IEnumerable<int> providers,int? CountrySelected, int? PhotoSelected)
        {
            if (ModelState.IsValid)
            {   
                repo.Create(marble, providers, CountrySelected, PhotoSelected);
                return RedirectToAction("Index");
            }
            MarbleCreateViewModel vm = new MarbleCreateViewModel();
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

            MarbleEditViewModel vm= new MarbleEditViewModel(marble);
            return View(vm);
        }




        // POST: Marble/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarbleId,Name,Color")] Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected)
        {
            if (ModelState.IsValid)
            {
                // db.Entry(marble).State = EntityState.Modified;
                // db.SaveChanges();
                repo.Update(marble, providers, CountrySelected, PhotoSelected);
                return RedirectToAction("Index");
            }
            MarbleEditViewModel vm = new MarbleEditViewModel(marble);
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





        public ActionResult ShowMarbles()
        {
            var marbles = repo.GetAll();
            return View(marbles);
        }

        
        public ActionResult ShowMarblesDetails(int? id)
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

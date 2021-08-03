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
using Omadiko.RepositoryServices.DataAccess;
using Omadiko.WebApp.ViewModels;

namespace Omadiko.WebApp.Controllers
{
    public class MarbleController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ApplicationDbContext());


        //LIKE
        public ActionResult LikeAddToList(int marbleId)
        {
            if (Session["like"] == null)
            {
                List<Item> MList = new List<Item>();
                var marble = unitOfWork.Marbles.Get(marbleId);
                MList.Add(new Item()
                {
                    Marble = marble
                });
                Session["like"] = MList;
            }
            else
            {
                List<Item> MList = (List<Item>)Session["like"];
                var marble = unitOfWork.Marbles.Get(marbleId);
                MList.Add(new Item()
                {
                    Marble = marble,
                    Quantity = 1
                });
                Session["like"] = MList;
            }
            
            return Redirect("Index");
        }

        // GET: Marble
        public ActionResult Index()
        {
            var marbles = unitOfWork.Marbles.GetAll();
            return View(marbles);           
        }

        // GET: Marble/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marble marble = unitOfWork.Marbles.GetById(id);
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
                unitOfWork.Marbles.Create(marble, providers, CountrySelected, PhotoSelected);
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
            Marble marble = unitOfWork.Marbles.GetById(id);
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
                unitOfWork.Marbles.Update(marble, providers, CountrySelected, PhotoSelected);
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
            Marble marble = unitOfWork.Marbles.GetById(id);
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
            unitOfWork.Marbles.Delete(id);
            return RedirectToAction("Index");
        }

        public ActionResult ShowMarbles()
        {
            var marbles = unitOfWork.Marbles.GetAll();
            return View(marbles);
        }

        
        public ActionResult ShowMarblesDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marble marble = unitOfWork.Marbles.GetById(id);
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
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using Omadiko.Database;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices;
using Omadiko.RepositoryServices.DataAccess;
using Omadiko.WebApp.Models;

namespace Omadiko.WebApp.Controllers
{
    public class MarbleController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new ApplicationDbContext());
        private ApplicationUserManager _userManager;
        public MarbleController()
        {

        }

        public MarbleController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
      

        //LIKE
        public async Task<ActionResult> LikeAddToList(int marbleId, string userId)
        {
            #region Session Code in Comments
            //HashSet<Item> MList = new HashSet<Item>();
            //if (Session["like"] == null)
            //{
            //    var marble = unitOfWork.Marbles.Get(marbleId);
            //    MList.Append(new Item()
            //    {
            //        Marble = marble
            //    });
            //
            //    Session["like"] = MList;
            //}
            //else
            //{
            //    MList = (HashSet<Item>)Session["like"];
            //    var marble = unitOfWork.Marbles.Get(marbleId);
            //    MList.Append(new Item()
            //    {
            //        Marble = marble
            //    });
            //    Session["like"] = MList;
            //}
            #endregion
            await UserManager.AttachUserList(userId, marbleId);
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
            ViewBag.RelativeMarble = unitOfWork.Marbles.GetAll().Where(x => x.Color == marble.Color).Where(x => x.MarbleId != marble.MarbleId);
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
        public ActionResult Create([Bind(Include = "MarbleId,Name,Color")] Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected)
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

            MarbleEditViewModel vm = new MarbleEditViewModel(marble);
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
            if (disposing && _userManager != null)
            {
                unitOfWork.Dispose();
                _userManager.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}

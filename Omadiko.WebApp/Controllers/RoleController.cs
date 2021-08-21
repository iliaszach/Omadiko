using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Omadiko.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Role
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.IsInRole("Admin"))
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            var Roles = context.Roles.ToList();
            return View(Roles);

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Name)
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (ModelState.IsValid)
            {
                if (!roleManager.RoleExists(Name))
                {                   
                    var role = new IdentityRole();
                    role.Name = Name;
                    roleManager.Create(role);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();

        }
    }
}
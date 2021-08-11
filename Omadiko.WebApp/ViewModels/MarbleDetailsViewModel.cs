using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.ViewModels
{
    public class MarbleDetailsViewModel
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Marble Marble { get; set; }

        public MarbleDetailsViewModel()
        {

        }

    }
}
using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.ViewModels
{
    public class MarbleCreateViewModel
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Marble Marble { get; set; }

        public MarbleCreateViewModel()
        {

        }

        public SelectList CountrySelected
        {
            get
            {
                return new SelectList(db.Countries, "CountryId", "Name");
            }
        }

        public SelectList PhotoSelected
        {
            get
            {
                return new SelectList(db.Photos, "PhotoId", "PhotoName");
            }
        }


        public IEnumerable<SelectListItem> Providers
        {

            get
            {
                return db.Providers.ToList().Select(x => new SelectListItem
                {
                    Value = x.ProviderId.ToString(),
                    Text = x.CompanyTitle
                });
            }
        }
    }
}
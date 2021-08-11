using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Models
{
    public class MarbleEditViewModel
    {

        ApplicationDbContext db = new ApplicationDbContext();

        public Marble Marble { get; set; }

        //public IEnumerable<Country> countries
        //{
        //    get { return db.Countries.ToList(); }
        //    set { value = countries; }
        //}

        public MarbleEditViewModel(Marble marble)
        {
            Marble = marble;
        }


        public IEnumerable<SelectListItem> Providers
        {

            get
            {
                if (Marble is null)
                {
                    return db.Providers.ToList().Select(x => new SelectListItem
                    {
                        Value = x.ProviderId.ToString(),
                        Text = x.CompanyTitle
                    });
                }
                else
                {
                    var providerId = Marble.Providers.Select(x => x.ProviderId);

                    return db.Providers.ToList().Select(x => new SelectListItem
                    {
                        Value = x.ProviderId.ToString(),
                        Text = x.CompanyTitle,
                        Selected = providerId.Any(y => y == x.ProviderId)
                    });
                }
            }
        }



        public SelectList CountrySelected
        {
            get
            {
                if (Marble is null)
                {
                    return new SelectList(db.Countries, "CountryId", "Name");
                }
                else
                {
                    var country = Marble.Country;

                    return new SelectList(db.Countries, "CountryId", "Name");
                }
            }
        }

        public SelectList PhotoSelected
        {
            get
            {
                if (Marble is null)
                {
                    return new SelectList(db.Photos, "PhotoId", "PhotoName");
                }
                else
                {
                    var photo = Marble.Photo;

                    return new SelectList(db.Photos, "PhotoId", "PhotoName", photo);
                }
            }
        }

    }
}
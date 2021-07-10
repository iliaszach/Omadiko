using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.ViewModels
{
    public class ProviderCreateViewModel
    {
        public Provider Provider  { get; set; }
        public ProviderCreateViewModel()
        {
            
        }
        public ProviderCreateViewModel(Provider provider)
        {
            Provider = provider;
        }
        ApplicationDbContext db = new ApplicationDbContext();
        public SelectList Locations 
        { 
            get
            {
                return new SelectList(db.Locations, "LocationId", "Country");
            }
        }
        public SelectList SelectedLocations 
        { 
            get
            {
                return new SelectList(db.Locations, "LocationId", "Country", Provider.LocationId);
            }
        }
    }
}
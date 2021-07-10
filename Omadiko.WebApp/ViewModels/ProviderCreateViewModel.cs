﻿using Omadiko.Database;
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
        ApplicationDbContext db = new ApplicationDbContext();

        public Provider Provider  { get; set; }
        public ProviderCreateViewModel()
        {
            
        }

        public SelectList Location { 
            get 
            {
                return new SelectList(db.Locations,"LocationId","Country");
            } 
        }


        public IEnumerable<SelectListItem> Marbles {

            get 
            {
                return db.Marbles.ToList().Select(x => new SelectListItem 
                {
                 Value = x.MarbleId.ToString(),
                 Text = x.Name
                });
            }        
        }
        public IEnumerable<SelectListItem> BusinessTypes {

            get 
            {
                return db.BusinessTypes.ToList().Select(x => new SelectListItem 
                {
                 Value = x.BusinessTypeId.ToString(),
                 Text = x.Kind
                });
            }        
        }
    }
}
using Omadiko.Database;
using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.ViewModels
{
    public class ProviderEditViewModel
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public Provider Provider { get; set; }
        public ProviderEditViewModel(Provider provider)
        {
            Provider = provider;
        }

        public IEnumerable<SelectListItem> SelectedMarble {

            get
            {
                if (Provider is null)
                {
                    return db.Marbles.ToList().Select(x => new SelectListItem
                    {
                        Value = x.MarbleId.ToString(),
                        Text = x.Name
                    });
                }
                else
                {
                    var marbleId = Provider.Marbles.Select(x => x.MarbleId);
                    return db.Marbles.ToList().Select(x => new SelectListItem
                    {
                        Value = x.MarbleId.ToString(),
                        Text = x.Name,
                        Selected = marbleId.Any(y => y == x.MarbleId)
                    });
                }
            }
            
            
            
            

        }

    }
}
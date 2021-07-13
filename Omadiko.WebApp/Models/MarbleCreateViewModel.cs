using Omadiko.Entities.Models;
using Omadiko.RepositoryServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Omadiko.WebApp.Models
{
    public class MarbleCreateViewModel
    {
        private MarbleRepository repo = new MarbleRepository();
        private PhotoRepository repoPhoto = new PhotoRepository();
        private LocationRepository repoLoc = new LocationRepository();

        public IEnumerable<SelectListItem> SelectedLocationIds
        {
            get
            {
                return repoLoc.GetAll().ToList().Select(x => new SelectListItem()
                {              
                    Value = x.LocationId.ToString(),
                    Text = x.Country
                });
            }
        }
        public IEnumerable<SelectListItem> SelectedPhotoIds
        {
            get
            {
                return repoPhoto.GetAll().ToList().Select(x => new SelectListItem()
                {
                    Value = x.PhotoId.ToString(),
                    Text = x.PhotoName
                });
            }
        }

        public Marble marble{ get; set; }


    }
}
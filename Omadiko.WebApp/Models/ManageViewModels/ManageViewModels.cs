using System.Collections.Generic;
using Omadiko.Entities;

namespace Omadiko.WebApp.Models
{

    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}
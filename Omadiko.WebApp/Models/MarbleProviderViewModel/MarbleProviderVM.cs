using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Omadiko.WebApp.Models.MarbleProviderViewModel
{
    public class MarbleProviderVM
    {
        public List<Marble> Marbles { get; set; }
        public List<Provider> Providers { get; set; }

        //public MarbleProviderVM(IEnumerable<Marble> marble, IEnumerable<Provider> providers)
        //{
        //    Marbles = marble;
        //    Providers = providers;
        //}
    }
}
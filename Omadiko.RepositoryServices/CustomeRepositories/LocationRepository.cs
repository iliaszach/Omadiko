using Omadiko.Database;
using Omadiko.Entities.Models;
using Omadiko.RepositoryServices.InterfaceCustomRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    public class LocationRepository: Repository<Location>, ILocationRepository
    {
        public LocationRepository(ApplicationDbContext context):base(context)
        {
        }
        public ApplicationDbContext DBContext
        {
            get
            {
                return Context as ApplicationDbContext;
            }
        }
        public Location GetWhereProvider(Provider provider, int? id)
        {
            return DBContext.Locations.Where(x => x.Provider.ProviderId == provider.ProviderId).Single();
        }


    }
}

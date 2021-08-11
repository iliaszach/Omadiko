using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices.InterfaceCustomRepositories
{
    public interface ILocationRepository:IRepository<Location>
    {
        Location GetWhereProvider(Provider provider, int? id);
    }
}

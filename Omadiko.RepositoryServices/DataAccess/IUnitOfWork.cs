using Omadiko.Entities.Models;
using Omadiko.RepositoryServices.CustomRepositories;
using Omadiko.RepositoryServices.InterfaceCustomRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices.DataAccess
{
    public interface IUnitOfWork:IDisposable
    {
        IProviderRepository Providers { get; }
        ILocationRepository Locations { get; }
        void Save();
    }
}

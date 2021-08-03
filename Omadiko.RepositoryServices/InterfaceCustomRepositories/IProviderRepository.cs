using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices.CustomRepositories
{
    public interface IProviderRepository: IRepository<Provider>
    {
        //This interface derives from the generic repositry interface and
        //has and Additional operations based on the needs of the class Provider
         
        void Create(Provider provider, Location Location, IEnumerable<int> Marbles, IEnumerable<int> BusinessTypes);
        void Delete(int id);
        void Update(Provider provider, Location location, IEnumerable<int> Marbles, IEnumerable<int> BusinessTypes);
        IEnumerable<Provider> GetProviderByMarble(Marble marble);
        IEnumerable<Provider> GetProviderByMarbleId(int id);
        IEnumerable<Provider> GetProviderByCountry(Location location);
        IEnumerable<Provider> GetProviderByLocationId(int id);
        



    }
}

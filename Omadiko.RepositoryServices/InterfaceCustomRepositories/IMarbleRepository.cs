using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices.InterfaceCustomRepositories
{
    public interface IMarbleRepository: IRepository<Marble>
    {
        void Create(Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected);
        void Update(Marble marble, IEnumerable<int> providers, int? CountrySelected, int? PhotoSelected);
        void Delete(int id);
        IEnumerable<Marble> GetMarbleByColor(string color);
        IEnumerable<Marble> GetMarbleByProvider(Provider provider);
        IEnumerable<Marble> GetMarbleByProviderId(int id);
        IEnumerable<Marble> GetMarbleByCountry(Location location);
        IEnumerable<Marble> GetMarbleByLocationId(int id);
    }
}

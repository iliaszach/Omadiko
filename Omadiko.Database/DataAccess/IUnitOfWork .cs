using Omadiko.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.Database
{
    public interface IUnitOfWork:IDisposable
    {
        //Specify what type of repository instance it should return to us, while
        //we are working in real-time
        //IGenericRepository<Marble> MarbleRepository { get; }
        //IGenericRepository<Provider> ProviderRepository { get; }
        //IGenericRepository<Location> LocationRepository { get; }
        
        //void Save();
    }
}

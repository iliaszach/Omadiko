using Omadiko.Database;
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
    //Specific to our application

    public class UnitOfWork:IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        //It receives ApplicationDbContext in the ctor and store it in a private field [ _context ]
        //and use the same context to initialize the repositories. 
        //So the client of Unit of work will instantiate a ApplicationDbContext and use these context across all repositories.
        //
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Providers = new ProviderRepository(_context);
            Locations = new LocationRepository(_context);
        }

        public IProviderRepository Providers { get; private set; }

        public ILocationRepository Locations { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

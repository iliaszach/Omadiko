using Omadiko.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    //Implementation of IRepository
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        //It takes a DbContext in its constructor. The DbContext its generic ==> Nothing to do with Marble Project App
        //Its protected because it's gone to used ONLY in derived classes (ProviderRepository,MarbleRepository etc) 
        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context; 
        }

        //Set methods returns a DbSet<TEntity> instance for access in entities for the given type in the Context and underlying the store.
        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }
        public TEntity GetById(int? id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        //Does not return IQuerable, because Repositories should not return IQuerable.
        //Because it can give wrong impression to the upper layers like services or controllers, that they can use this 
        //IQuerable to built queries. Its completely against the idea of using a repository in the first place.
        public IEnumerable<TEntity> GetAll() 
        {
            return Context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(int entity)
        {
            var deletedEntity = Context.Set<TEntity>().Find(entity);
            Context.Set<TEntity>().Remove(deletedEntity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        
    }


}

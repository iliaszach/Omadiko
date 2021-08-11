using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Omadiko.RepositoryServices
{
    public interface IRepository<TEntity> where TEntity:class
    {
        //Methods Purpose:  FIND OBJECTS        
        TEntity GetById(int? id);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate); //we can use a lambda expression to filter objects ==> return boolean [like "Where" method]

        //Methods Purpose:  ADD OBJECTS       
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //Methods Purpose:  DELETE OBJECTS       
        void Remove(int entity);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}

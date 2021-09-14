using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Trading.Core.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Get 
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //Add
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //Remove

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}

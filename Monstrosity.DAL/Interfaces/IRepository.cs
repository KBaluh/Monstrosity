using System;
using System.Collections.Generic;

namespace Monstrosity.DAL.Interfaces
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        TEntity Get(TKey key);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> filter);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TKey key);
    }
}

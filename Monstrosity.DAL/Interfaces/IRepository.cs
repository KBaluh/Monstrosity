using System.Collections.Generic;

namespace Monstrosity.DAL.Interfaces
{
    public interface IRepository<TModel, TKey> where TModel : class
    {
        TModel Get(TKey key);
        IEnumerable<TModel> GetAll();
        void Create(TModel entity);
        void Update(TModel entity);
        void Delete(TKey key);
    }
}

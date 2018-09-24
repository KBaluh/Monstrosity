using System.Collections.Generic;

namespace Monstrosity.DAL.Interfaces
{
    public interface IRepository<TModel, TKey> where TModel : class
    {
        TModel Get(TKey key);
        IEnumerable<TModel> GetAll();
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TKey key);
    }
}

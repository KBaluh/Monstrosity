using System.Collections.Generic;

namespace Monstrosity.BLL.Interfaces
{
    public interface IBaseService<TModel, TKey>
    {
        IEnumerable<TModel> GetAll();
        TModel Get(TKey id);
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TKey id);
    }
}

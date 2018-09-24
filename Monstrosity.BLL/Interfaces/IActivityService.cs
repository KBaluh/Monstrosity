using Monstrosity.BLL.Models;
using System.Collections.Generic;

namespace Monstrosity.BLL.Interfaces
{
    public interface IActivityService
    {
        IEnumerable<ActivityDTO> GetAll();
        ActivityDTO Get(int id);
        void Create(ActivityDTO model);
        void Update(ActivityDTO model);
        void Delete(int id);
    }
}

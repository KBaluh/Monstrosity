using Monstrosity.BLL.Models;
using System.Collections.Generic;

namespace Monstrosity.BLL.Interfaces
{
    public interface IActivityService : IBaseService<ActivityDTO, int>
    {
        IEnumerable<ActivityDTO> GetNotStarted();
        IEnumerable<ActivityDTO> GetInProgress();
        IEnumerable<ActivityDTO> GetClosed();
    }
}

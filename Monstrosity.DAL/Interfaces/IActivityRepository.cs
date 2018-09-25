using Monstrosity.DAL.Entities;
using System.Collections.Generic;

namespace Monstrosity.DAL.Interfaces
{
    public interface IActivityRepository : IRepository<Activity, int>
    {
        IEnumerable<Activity> GetNotStarted();
        IEnumerable<Activity> GetInProgress();
        IEnumerable<Activity> GetClosed();
    }
}

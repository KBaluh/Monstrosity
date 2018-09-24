using Monstrosity.DAL.Entities;
using System;
using System.Collections.Generic;

namespace Monstrosity.DAL.Interfaces
{
    public interface IActivityRepository : IRepository<Activity, int>
    {
        IEnumerable<Activity> GetAll(Func<Activity, bool> filter);
    }
}

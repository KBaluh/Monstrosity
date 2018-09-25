using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Models;
using Monstrosity.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstrosity.BLL.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IActivityUoW _activityUoW;

        public ActivityService(IActivityUoW activityUoW)
        {
            _activityUoW = activityUoW;
        }

        public ActivityDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActivityDTO> GetAll()
        {
            var list = new List<ActivityDTO>();
            var activities = _activityUoW.Activities.GetAll();
            foreach (var activity in activities)
            {
                list.Add(new ActivityDTO { ActivityId = activity.ActivityId, Title = activity.Title });
            }
            return list;
        }

        public void Create(ActivityDTO model)
        {
            throw new NotImplementedException();
        }

        public void Update(ActivityDTO model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Models;
using Monstrosity.DAL.Entities;
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
            var activities = _activityUoW.Activities.GetAll();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Activity, ActivityDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Activity>, List<ActivityDTO>>(activities);
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

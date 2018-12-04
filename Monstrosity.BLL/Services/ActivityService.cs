using AutoMapper;
using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Models;
using Monstrosity.DAL.Entities;
using Monstrosity.DAL.Interfaces;
using System.Collections.Generic;

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
            var activity = _activityUoW.Activities.Get(id);
            return GetEntityMapper().Map<Activity, ActivityDTO>(activity);
        }

        public IEnumerable<ActivityDTO> GetAll()
        {
            var activities = _activityUoW.Activities.GetAll();
            return GetEntityMapper().Map<IEnumerable<Activity>, IEnumerable<ActivityDTO>>(activities);
        }

        public void Create(ActivityDTO model)
        {
            var entity = GetTDOMapper().Map<ActivityDTO, Activity>(model);
            try
            {
                _activityUoW.Activities.Create(entity);
                _activityUoW.Commit();
            }
            catch
            {
                _activityUoW.RejectChanges();
                throw;
            }
        }

        public void Update(ActivityDTO model)
        {
            var entity = GetTDOMapper().Map<ActivityDTO, Activity>(model);
            try
            {
                _activityUoW.Activities.Update(entity);
                _activityUoW.Commit();
            }
            catch
            {
                _activityUoW.RejectChanges();
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _activityUoW.Activities.Delete(id);
                _activityUoW.Commit();
            }
            catch
            {
                _activityUoW.RejectChanges();
                throw;
            }
        }

        public IEnumerable<ActivityDTO> GetNotStarted()
        {
            var entities = _activityUoW.Activities.GetNotStarted();
            return GetEntityMapper().Map<IEnumerable<Activity>, IEnumerable<ActivityDTO>>(entities);
        }

        public IEnumerable<ActivityDTO> GetInProgress()
        {
            var entities = _activityUoW.Activities.GetInProgress();
            return GetEntityMapper().Map<IEnumerable<Activity>, IEnumerable<ActivityDTO>>(entities);
        }

        public IEnumerable<ActivityDTO> GetClosed()
        {
            var entities = _activityUoW.Activities.GetClosed();
            return GetEntityMapper().Map<IEnumerable<Activity>, IEnumerable<ActivityDTO>>(entities);
        }

        private IMapper GetEntityMapper()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Activity, ActivityDTO>()).CreateMapper();
            return mapper;
        }

        private IMapper GetTDOMapper()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<ActivityDTO, Activity>()).CreateMapper();
            return mapper;
        }
    }
}

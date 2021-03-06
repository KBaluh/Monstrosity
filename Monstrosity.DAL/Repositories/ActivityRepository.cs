﻿using Monstrosity.DAL.EF;
using Monstrosity.DAL.Entities;
using Monstrosity.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Monstrosity.DAL.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly MonsterContext _context;

        public ActivityRepository(MonsterContext context)
        {
            _context = context;
        }

        public Activity Get(int key)
        {
            return _context.Activities.Find(key);
        }

        public IEnumerable<Activity> GetAll(Func<Activity, bool> filter)
        {
            return _context.Activities.Where(filter).ToList();
        }

        public IEnumerable<Activity> GetAll()
        {
            return _context.Activities.ToList();
        }

        public void Create(Activity entity)
        {
            _context.Activities.Add(entity);
        }

        public void Update(Activity entity)
        {
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int key)
        {
            var entity = _context.Activities.Find(key);
            if (entity != null)
                _context.Activities.Remove(entity);
        }

        public IEnumerable<Activity> GetNotStarted()
        {
            return _context.Activities.Where(a => a.ActivityStateId == 1).ToList();
        }

        public IEnumerable<Activity> GetInProgress()
        {
            return _context.Activities.Where(a => a.ActivityStateId == 2).ToList();
        }

        public IEnumerable<Activity> GetClosed()
        {
            return _context.Activities.Where(a => a.ActivityStateId == 3).ToList();
        }
    }
}

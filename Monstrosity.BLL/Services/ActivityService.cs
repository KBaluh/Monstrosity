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
        private readonly IActivityRepository _repository;

        public ActivityService(IActivityRepository repository)
        {
            _repository = repository;
        }

        public ActivityDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ActivityDTO> GetAll()
        {
            throw new NotImplementedException();
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

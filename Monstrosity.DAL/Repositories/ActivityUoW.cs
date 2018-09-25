using Monstrosity.DAL.EF;
using Monstrosity.DAL.Interfaces;

namespace Monstrosity.DAL.Repositories
{
    public class ActivityUoW : BaseUnitOfWork<MonsterContext>, IActivityUoW
    {
        public IActivityRepository Activities { get; private set; }

        public ActivityUoW(MonsterContext context, IActivityRepository activityRepository) : base(context)
        {
            Activities = activityRepository;
        }
    }
}

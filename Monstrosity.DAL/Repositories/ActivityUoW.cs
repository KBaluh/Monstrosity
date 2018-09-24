using Monstrosity.DAL.EF;
using Monstrosity.DAL.Interfaces;

namespace Monstrosity.DAL.Repositories
{
    public class ActivityUoW : BaseUnitOfWork<MosterContext>, IActivityUoW
    {
        public IActivityRepository Activities { get; private set; }

        public ActivityUoW(MosterContext context, IActivityRepository activityRepository) : base(context)
        {
            Activities = activityRepository;
        }
    }
}

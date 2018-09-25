using Monstrosity.DAL.EF;
using Monstrosity.DAL.Interfaces;
using Monstrosity.DAL.Repositories;
using SimpleInjector;

namespace Monstrosity.DAL.Infrastructure
{
    public class DALInject
    {
        public void Inject(Container container)
        {
            container.Register<MosterContext>(Lifestyle.Scoped);
            container.Register<IActivityRepository, ActivityRepository>();
            container.Register<IActivityUoW, ActivityUoW>();
        }
    }
}

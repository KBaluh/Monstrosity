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
            container.Register<MonsterContext>(Lifestyle.Scoped);
            container.Register<IContextProvider<MonsterContext>, MonsterContextProvider>(Lifestyle.Scoped);
            container.Register<IActivityRepository, ActivityRepository>(Lifestyle.Scoped);
            container.Register<IActivityUoW, ActivityUoW>(Lifestyle.Scoped);
            container.Register<IContactRepository, ContactRepository>(Lifestyle.Scoped);
        }
    }
}

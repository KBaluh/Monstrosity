using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Services;
using SimpleInjector;

namespace Monstrosity.BLL.Infrastructure
{
    public class BLLInject
    {
        public void Inject(Container container)
        {
            var dalInjector = new DAL.Infrastructure.DALInject();
            dalInjector.Inject(container);

            container.Register<IActivityService, ActivityService>();
        }
    }
}

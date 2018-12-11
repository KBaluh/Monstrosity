using Monstrosity.BLL.Interfaces;
using Monstrosity.BLL.Services;
using Monstrosity.DAL.EF;
using Monstrosity.DAL.Interfaces;
using Monstrosity.DAL.Repositories;
using Ninject.Modules;

namespace Monstrosity.BLL.Infrastructure
{
    public class NinjectBindModule : NinjectModule
    {
        public override void Load()
        {
            // DAL
            Bind<IActivityRepository>().To<ActivityRepository>();
            Bind<IContactRepository>().To<ContactRepository>();

            BindActivityUoWContext();

            // BLL
            Bind<IActivityService>().To<ActivityService>();
            Bind<IContactService>().To<ContactService>();
        }

        private void BindActivityUoWContext()
        {
            var context = (MonsterContext)Kernel.GetService(typeof(MonsterContext));
            Bind<IActivityUoW>().To<ActivityUoW>().WithConstructorArgument("context", context);
            Bind<IActivityRepository>().To<ActivityRepository>().WhenInjectedInto<ActivityUoW>().WithConstructorArgument("context", context);
            Bind<IContactRepository>().To<ContactRepository>().WhenInjectedInto<ActivityUoW>().WithConstructorArgument("context", context);

            // ContactUoW in OrderService as ContactService parameter
            /*Bind<IContactService>()
                .ToConstructor(_ => new ContactService(new ContactUoW(context, new ContactRepository(context), new ContactPhoneRepository(context))))
                .WhenInjectedInto<OrderService>();*/
        }
    }
}

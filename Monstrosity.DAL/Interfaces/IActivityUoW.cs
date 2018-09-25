using Monstrosity.DAL.EF;

namespace Monstrosity.DAL.Interfaces
{
    public interface IActivityUoW : IUnitOfWork<MonsterContext>
    {
        IActivityRepository Activities { get; }
        IContactRepository Contacts { get; }
    }
}

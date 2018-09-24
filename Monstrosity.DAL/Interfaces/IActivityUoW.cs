using Monstrosity.DAL.EF;

namespace Monstrosity.DAL.Interfaces
{
    public interface IActivityUoW : IUnitOfWork<MosterContext>
    {
        IActivityRepository Activities { get; }
    }
}

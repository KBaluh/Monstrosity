using System.Data.Entity;

namespace Monstrosity.DAL.Interfaces
{
    public interface IUnitOfWork<TContext> where TContext : DbContext
    {
        void Commit();
        void RejectChanges();
        void Dispose();
    }
}

namespace Monstrosity.DAL.Interfaces
{
    public interface IContextProvider<TContext>
    {
        TContext Context { get; }
    }
}

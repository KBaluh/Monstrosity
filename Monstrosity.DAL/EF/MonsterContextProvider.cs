using Monstrosity.DAL.Interfaces;

namespace Monstrosity.DAL.EF
{
    public class MonsterContextProvider : IContextProvider<MonsterContext>
    {
        public MonsterContext Context { get; private set; }

        public MonsterContextProvider()
        {
            Context = new MonsterContext();
        }
    }
}

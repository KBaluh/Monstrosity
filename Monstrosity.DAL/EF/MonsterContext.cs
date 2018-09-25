using Monstrosity.DAL.Entities;
using System.Data.Entity;

namespace Monstrosity.DAL.EF
{
    public class MonsterContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityState> ActivityStates { get; set; }

        public MonsterContext() : base("DefaultConnection")
        {
        }
    }
}

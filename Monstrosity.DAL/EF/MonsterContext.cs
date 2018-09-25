using Monstrosity.DAL.Entities;
using System.Data.Entity;

namespace Monstrosity.DAL.EF
{
    public class MonsterContext : DbContext
    {
        public DbSet<ActivityState> ActivityStates { get; set; }
        public DbSet<Activity> Activities { get; set; }

        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public MonsterContext() : base("DefaultConnection")
        {
        }
    }
}

using Monstrosity.DAL.Entities;
using System.Data.Entity;

namespace Monstrosity.DAL.EF
{
    public class MosterContext : DbContext
    {
        public DbSet<Activity> Activities { get; set; }

        public MosterContext() : base("DefaultConnection")
        {

        }
    }
}

namespace Monstrosity.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Monstrosity.DAL.EF.MonsterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Monstrosity.DAL.EF.MonsterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.ActivityStates.AddOrUpdate(
                new Entities.ActivityState { ActivityStateId = 1, Name = "Not Active" },
                new Entities.ActivityState { ActivityStateId = 2, Name = "Active" },
                new Entities.ActivityState { ActivityStateId = 3, Name = "InProgress" },
                new Entities.ActivityState { ActivityStateId = 4, Name = "Closed" }
            );
        }
    }
}

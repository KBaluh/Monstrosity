namespace Monstrosity.DAL.Migrations
{
    using Monstrosity.DAL.EF;
    using Monstrosity.DAL.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Monstrosity.DAL.EF.MonsterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MonsterContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.ActivityStates.AddOrUpdate(
                new ActivityState { ActivityStateId = 1, Name = "Not Active" },
                new ActivityState { ActivityStateId = 2, Name = "Active" },
                new ActivityState { ActivityStateId = 3, Name = "InProgress" },
                new ActivityState { ActivityStateId = 4, Name = "Closed" }
            );

            context.ContactTypes.AddOrUpdate(
                new ContactType { ContactTypeId = 1, Name = "Regular" },
                new ContactType { ContactTypeId = 2, Name = "Potential" },
                new ContactType { ContactTypeId = 3, Name = "Employee" }
            );
        }
    }
}

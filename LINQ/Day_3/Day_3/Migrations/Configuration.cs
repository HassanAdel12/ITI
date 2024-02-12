namespace Day_3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Day_3.Data>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Day_3.Data";
        }

        protected override void Seed(Day_3.Data context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}

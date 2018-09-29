namespace EatForHealth.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EatForHealth.DBContext.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EatForHealth.DBContext.ApplicationDbContext";
        }

        protected override void Seed(EatForHealth.DBContext.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }

    internal sealed class EFHConfiguration : DbMigrationsConfiguration<EatForHealth.DBContext.EFHDbContext>
    {
        public EFHConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "EatForHealth.DBContext.EFHDbContext";
        }

        protected override void Seed(EatForHealth.DBContext.EFHDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

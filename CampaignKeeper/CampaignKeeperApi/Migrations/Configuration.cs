namespace CampaignKeeperApi.Migrations
{
    using CampaignKeeperPcl;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CampaignKeeperApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CampaignKeeperApi.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Moneys.AddOrUpdate(m => m.Name,
                new Money { Name = "Platinum", Value = 10 },
                new Money { Name = "Gold", Value = 1 },
                new Money { Name = "Electrum", Value = .5m },
                new Money { Name = "Silver", Value = .1m },
                new Money { Name = "Copper", Value = .01m });
        }
    }
}

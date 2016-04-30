namespace CampaignKeeperApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountryDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Description", c => c.String());
            AddColumn("dbo.Locations", "History", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "History");
            DropColumn("dbo.Locations", "Description");
        }
    }
}

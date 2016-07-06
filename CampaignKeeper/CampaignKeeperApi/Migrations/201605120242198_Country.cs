namespace CampaignKeeperApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Country : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "Constitution1", c => c.String());
            AddColumn("dbo.Legislatures", "Republic_Id", c => c.Int());
            CreateIndex("dbo.Legislatures", "Republic_Id");
            AddForeignKey("dbo.Legislatures", "Republic_Id", "dbo.Locations", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Legislatures", "Republic_Id", "dbo.Locations");
            DropIndex("dbo.Legislatures", new[] { "Republic_Id" });
            DropColumn("dbo.Legislatures", "Republic_Id");
            DropColumn("dbo.Locations", "Constitution1");
        }
    }
}

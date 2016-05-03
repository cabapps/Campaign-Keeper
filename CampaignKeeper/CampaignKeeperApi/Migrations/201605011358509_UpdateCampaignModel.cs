namespace CampaignKeeperApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCampaignModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Campaigns", "Theme", c => c.String());
            AddColumn("dbo.Campaigns", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Campaigns", "Description");
            DropColumn("dbo.Campaigns", "Theme");
        }
    }
}

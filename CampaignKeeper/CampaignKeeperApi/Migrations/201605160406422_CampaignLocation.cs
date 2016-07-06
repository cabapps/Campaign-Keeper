namespace CampaignKeeperApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampaignLocation : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Locations", "Campaign_Id", "dbo.Campaigns");
            DropIndex("dbo.Locations", new[] { "Campaign_Id" });
            RenameColumn(table: "dbo.Locations", name: "Campaign_Id", newName: "CampaignId");
            AlterColumn("dbo.Locations", "CampaignId", c => c.Int(nullable: false));
            CreateIndex("dbo.Locations", "CampaignId");
            AddForeignKey("dbo.Locations", "CampaignId", "dbo.Campaigns", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "CampaignId", "dbo.Campaigns");
            DropIndex("dbo.Locations", new[] { "CampaignId" });
            AlterColumn("dbo.Locations", "CampaignId", c => c.Int());
            RenameColumn(table: "dbo.Locations", name: "CampaignId", newName: "Campaign_Id");
            CreateIndex("dbo.Locations", "Campaign_Id");
            AddForeignKey("dbo.Locations", "Campaign_Id", "dbo.Campaigns", "Id");
        }
    }
}

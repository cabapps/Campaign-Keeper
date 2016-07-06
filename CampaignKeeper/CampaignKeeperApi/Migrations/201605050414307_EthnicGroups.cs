namespace CampaignKeeperApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EthnicGroups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EthnicGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhysicalTraits = c.String(),
                        History = c.String(),
                        Name = c.String(),
                        Culture_Id = c.Int(),
                        Country_Id = c.Int(),
                        Continent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cultures", t => t.Culture_Id)
                .ForeignKey("dbo.Locations", t => t.Country_Id)
                .ForeignKey("dbo.Locations", t => t.Continent_Id)
                .Index(t => t.Culture_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Continent_Id);
            
            CreateTable(
                "dbo.Cultures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EthnicGroups", "Continent_Id", "dbo.Locations");
            DropForeignKey("dbo.EthnicGroups", "Country_Id", "dbo.Locations");
            DropForeignKey("dbo.EthnicGroups", "Culture_Id", "dbo.Cultures");
            DropIndex("dbo.EthnicGroups", new[] { "Continent_Id" });
            DropIndex("dbo.EthnicGroups", new[] { "Country_Id" });
            DropIndex("dbo.EthnicGroups", new[] { "Culture_Id" });
            DropTable("dbo.Cultures");
            DropTable("dbo.EthnicGroups");
        }
    }
}

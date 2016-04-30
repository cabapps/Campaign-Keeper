namespace CampaignKeeperApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adventures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CampaignEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Adventure_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adventures", t => t.Adventure_Id)
                .Index(t => t.Adventure_Id);
            
            CreateTable(
                "dbo.Campaigns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Map = c.String(),
                        Name = c.String(),
                        Depth = c.Int(),
                        Population = c.Int(),
                        EconomicStatus = c.Int(),
                        CrimeStatus = c.Int(),
                        Rooms = c.Int(),
                        Tables = c.Int(),
                        Height = c.Int(),
                        IsVolcanic = c.Boolean(),
                        IsPassable = c.Boolean(),
                        Current = c.Int(),
                        Length = c.Int(),
                        WoodlandType = c.Int(),
                        Constitution = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Country_Id = c.Int(),
                        Ruler_Id = c.Int(),
                        Owner_Id = c.Int(),
                        Ward_Id = c.Int(),
                        City_Id = c.Int(),
                        Town_Id = c.Int(),
                        Store_Id = c.Int(),
                        Country_Id1 = c.Int(),
                        Region_Id = c.Int(),
                        Region_Id1 = c.Int(),
                        Region_Id2 = c.Int(),
                        Region_Id3 = c.Int(),
                        SettledRegion_Id = c.Int(),
                        Ruler_Id1 = c.Int(),
                        SettledRegion_Id1 = c.Int(),
                        SettledRegion_Id2 = c.Int(),
                        Country_Id2 = c.Int(),
                        Monarch_Id = c.Int(),
                        Monarch_Id1 = c.Int(),
                        Continent_Id = c.Int(),
                        Continent_Id1 = c.Int(),
                        Waterbody_Id = c.Int(),
                        Campaign_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Country_Id)
                .ForeignKey("dbo.Characters", t => t.Ruler_Id)
                .ForeignKey("dbo.Characters", t => t.Owner_Id)
                .ForeignKey("dbo.Locations", t => t.Ward_Id)
                .ForeignKey("dbo.Locations", t => t.City_Id)
                .ForeignKey("dbo.Locations", t => t.Town_Id)
                .ForeignKey("dbo.Locations", t => t.Store_Id)
                .ForeignKey("dbo.Locations", t => t.Country_Id1)
                .ForeignKey("dbo.Locations", t => t.Region_Id)
                .ForeignKey("dbo.Locations", t => t.Region_Id1)
                .ForeignKey("dbo.Locations", t => t.Region_Id2)
                .ForeignKey("dbo.Locations", t => t.Region_Id3)
                .ForeignKey("dbo.Locations", t => t.SettledRegion_Id)
                .ForeignKey("dbo.Characters", t => t.Ruler_Id1)
                .ForeignKey("dbo.Locations", t => t.SettledRegion_Id1)
                .ForeignKey("dbo.Locations", t => t.SettledRegion_Id2)
                .ForeignKey("dbo.Locations", t => t.Country_Id2)
                .ForeignKey("dbo.Characters", t => t.Monarch_Id)
                .ForeignKey("dbo.Characters", t => t.Monarch_Id1)
                .ForeignKey("dbo.Locations", t => t.Continent_Id)
                .ForeignKey("dbo.Locations", t => t.Continent_Id1)
                .ForeignKey("dbo.Locations", t => t.Waterbody_Id)
                .ForeignKey("dbo.Campaigns", t => t.Campaign_Id)
                .Index(t => t.Country_Id)
                .Index(t => t.Ruler_Id)
                .Index(t => t.Owner_Id)
                .Index(t => t.Ward_Id)
                .Index(t => t.City_Id)
                .Index(t => t.Town_Id)
                .Index(t => t.Store_Id)
                .Index(t => t.Country_Id1)
                .Index(t => t.Region_Id)
                .Index(t => t.Region_Id1)
                .Index(t => t.Region_Id2)
                .Index(t => t.Region_Id3)
                .Index(t => t.SettledRegion_Id)
                .Index(t => t.Ruler_Id1)
                .Index(t => t.SettledRegion_Id1)
                .Index(t => t.SettledRegion_Id2)
                .Index(t => t.Country_Id2)
                .Index(t => t.Monarch_Id)
                .Index(t => t.Monarch_Id1)
                .Index(t => t.Continent_Id)
                .Index(t => t.Continent_Id1)
                .Index(t => t.Waterbody_Id)
                .Index(t => t.Campaign_Id);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Motto = c.String(),
                        Name = c.String(),
                        Settlement_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Settlement_Id)
                .Index(t => t.Settlement_Id);
            
            CreateTable(
                "dbo.Ranks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Renown = c.Int(nullable: false),
                        Name = c.String(),
                        Organization_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.Organization_Id)
                .Index(t => t.Organization_Id);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        History = c.String(),
                        Appearance = c.String(),
                        Bond = c.String(),
                        Ideal = c.String(),
                        Flaw = c.String(),
                        Name = c.String(),
                        HighAbility = c.String(),
                        LowAbility = c.String(),
                        Kingdom_Id = c.Int(),
                        Kingdom_Id1 = c.Int(),
                        Legislature_Id = c.Int(),
                        LegislativeMonarchy_Id = c.Int(),
                        LegislativeMonarchy_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Kingdom_Id)
                .ForeignKey("dbo.Locations", t => t.Kingdom_Id1)
                .ForeignKey("dbo.Legislatures", t => t.Legislature_Id)
                .ForeignKey("dbo.Locations", t => t.LegislativeMonarchy_Id)
                .ForeignKey("dbo.Locations", t => t.LegislativeMonarchy_Id1)
                .Index(t => t.Kingdom_Id)
                .Index(t => t.Kingdom_Id1)
                .Index(t => t.Legislature_Id)
                .Index(t => t.LegislativeMonarchy_Id)
                .Index(t => t.LegislativeMonarchy_Id1);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weight = c.Decimal(precision: 18, scale: 2),
                        Use = c.String(),
                        Capacity = c.String(),
                        IsStealthDisadvantage = c.Boolean(),
                        RequiredStrength = c.Int(),
                        DexModifier = c.Int(),
                        DexModifier1 = c.Int(),
                        ArmorBonus = c.Int(),
                        ProficiencyBonus = c.Int(),
                        WeaponType = c.Int(),
                        RangeType = c.Int(),
                        Damage = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Cost_Id = c.Int(),
                        Shop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Moneys", t => t.Cost_Id)
                .ForeignKey("dbo.Locations", t => t.Shop_Id)
                .Index(t => t.Cost_Id)
                .Index(t => t.Shop_Id);
            
            CreateTable(
                "dbo.Moneys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeaponProperties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Name = c.String(),
                        Count = c.Int(),
                        NormalRange = c.Int(),
                        MaximumRange = c.Int(),
                        NormalRange1 = c.Int(),
                        MaximumRange1 = c.Int(),
                        Damage = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Weapon_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Goods", t => t.Weapon_Id)
                .Index(t => t.Weapon_Id);
            
            CreateTable(
                "dbo.Legislatures",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LegislativeMonarchy_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LegislativeMonarchy_Id)
                .Index(t => t.LegislativeMonarchy_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        PlayerId = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.LakeRegions",
                c => new
                    {
                        Lake_Id = c.Int(nullable: false),
                        Region_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Lake_Id, t.Region_Id })
                .ForeignKey("dbo.Locations", t => t.Lake_Id)
                .ForeignKey("dbo.Locations", t => t.Region_Id)
                .Index(t => t.Lake_Id)
                .Index(t => t.Region_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Locations", "Campaign_Id", "dbo.Campaigns");
            DropForeignKey("dbo.Locations", "Waterbody_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Continent_Id1", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Continent_Id", "dbo.Locations");
            DropForeignKey("dbo.Characters", "LegislativeMonarchy_Id1", "dbo.Locations");
            DropForeignKey("dbo.Characters", "LegislativeMonarchy_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Monarch_Id1", "dbo.Characters");
            DropForeignKey("dbo.Legislatures", "LegislativeMonarchy_Id", "dbo.Locations");
            DropForeignKey("dbo.Characters", "Legislature_Id", "dbo.Legislatures");
            DropForeignKey("dbo.Characters", "Kingdom_Id1", "dbo.Locations");
            DropForeignKey("dbo.Characters", "Kingdom_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Monarch_Id", "dbo.Characters");
            DropForeignKey("dbo.Locations", "Country_Id2", "dbo.Locations");
            DropForeignKey("dbo.Locations", "SettledRegion_Id2", "dbo.Locations");
            DropForeignKey("dbo.Locations", "SettledRegion_Id1", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Ruler_Id1", "dbo.Characters");
            DropForeignKey("dbo.Locations", "SettledRegion_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Region_Id3", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Region_Id2", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Region_Id1", "dbo.Locations");
            DropForeignKey("dbo.LakeRegions", "Region_Id", "dbo.Locations");
            DropForeignKey("dbo.LakeRegions", "Lake_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Region_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Country_Id1", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Store_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Town_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "City_Id", "dbo.Locations");
            DropForeignKey("dbo.Locations", "Ward_Id", "dbo.Locations");
            DropForeignKey("dbo.Goods", "Shop_Id", "dbo.Locations");
            DropForeignKey("dbo.WeaponProperties", "Weapon_Id", "dbo.Goods");
            DropForeignKey("dbo.Goods", "Cost_Id", "dbo.Moneys");
            DropForeignKey("dbo.Locations", "Owner_Id", "dbo.Characters");
            DropForeignKey("dbo.Locations", "Ruler_Id", "dbo.Characters");
            DropForeignKey("dbo.Organizations", "Settlement_Id", "dbo.Locations");
            DropForeignKey("dbo.Ranks", "Organization_Id", "dbo.Organizations");
            DropForeignKey("dbo.Locations", "Country_Id", "dbo.Locations");
            DropForeignKey("dbo.CampaignEvents", "Adventure_Id", "dbo.Adventures");
            DropIndex("dbo.LakeRegions", new[] { "Region_Id" });
            DropIndex("dbo.LakeRegions", new[] { "Lake_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "PlayerId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Legislatures", new[] { "LegislativeMonarchy_Id" });
            DropIndex("dbo.WeaponProperties", new[] { "Weapon_Id" });
            DropIndex("dbo.Goods", new[] { "Shop_Id" });
            DropIndex("dbo.Goods", new[] { "Cost_Id" });
            DropIndex("dbo.Characters", new[] { "LegislativeMonarchy_Id1" });
            DropIndex("dbo.Characters", new[] { "LegislativeMonarchy_Id" });
            DropIndex("dbo.Characters", new[] { "Legislature_Id" });
            DropIndex("dbo.Characters", new[] { "Kingdom_Id1" });
            DropIndex("dbo.Characters", new[] { "Kingdom_Id" });
            DropIndex("dbo.Ranks", new[] { "Organization_Id" });
            DropIndex("dbo.Organizations", new[] { "Settlement_Id" });
            DropIndex("dbo.Locations", new[] { "Campaign_Id" });
            DropIndex("dbo.Locations", new[] { "Waterbody_Id" });
            DropIndex("dbo.Locations", new[] { "Continent_Id1" });
            DropIndex("dbo.Locations", new[] { "Continent_Id" });
            DropIndex("dbo.Locations", new[] { "Monarch_Id1" });
            DropIndex("dbo.Locations", new[] { "Monarch_Id" });
            DropIndex("dbo.Locations", new[] { "Country_Id2" });
            DropIndex("dbo.Locations", new[] { "SettledRegion_Id2" });
            DropIndex("dbo.Locations", new[] { "SettledRegion_Id1" });
            DropIndex("dbo.Locations", new[] { "Ruler_Id1" });
            DropIndex("dbo.Locations", new[] { "SettledRegion_Id" });
            DropIndex("dbo.Locations", new[] { "Region_Id3" });
            DropIndex("dbo.Locations", new[] { "Region_Id2" });
            DropIndex("dbo.Locations", new[] { "Region_Id1" });
            DropIndex("dbo.Locations", new[] { "Region_Id" });
            DropIndex("dbo.Locations", new[] { "Country_Id1" });
            DropIndex("dbo.Locations", new[] { "Store_Id" });
            DropIndex("dbo.Locations", new[] { "Town_Id" });
            DropIndex("dbo.Locations", new[] { "City_Id" });
            DropIndex("dbo.Locations", new[] { "Ward_Id" });
            DropIndex("dbo.Locations", new[] { "Owner_Id" });
            DropIndex("dbo.Locations", new[] { "Ruler_Id" });
            DropIndex("dbo.Locations", new[] { "Country_Id" });
            DropIndex("dbo.CampaignEvents", new[] { "Adventure_Id" });
            DropTable("dbo.LakeRegions");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Players");
            DropTable("dbo.Legislatures");
            DropTable("dbo.WeaponProperties");
            DropTable("dbo.Moneys");
            DropTable("dbo.Goods");
            DropTable("dbo.Characters");
            DropTable("dbo.Ranks");
            DropTable("dbo.Organizations");
            DropTable("dbo.Locations");
            DropTable("dbo.Campaigns");
            DropTable("dbo.CampaignEvents");
            DropTable("dbo.Adventures");
        }
    }
}

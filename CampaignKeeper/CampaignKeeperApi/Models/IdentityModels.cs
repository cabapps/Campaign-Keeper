using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;
using CampaignKeeperPcl;
using CampaignKeeperPcl.Organizations;
using CampaignKeeperPcl.Models.Cultures;
using CampaignKeeperPcl.Locations;
using CampaignKeeperPcl.Locations.Countries;

namespace CampaignKeeperApi.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public int PlayerId { get; set; }
        public Player Player { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Adventure> Adventures { get; set; }
        public DbSet<CampaignEvent> CampaignEvents { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Kingdom> Kingdoms { get; set; }
        public DbSet<Republic> Repubics { get; set; }
        public DbSet<LegislativeMonarchy> LegislativeMonarchies { get; set; }
        public DbSet<ConstitutionalRepublic> ConstitutionalRepublics { get; set; }
        public DbSet<Money> Moneys { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<EthnicGroup> EthnicGroups { get; set; }
        public DbSet<Culture> Cultures { get; set; }
    }
}
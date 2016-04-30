using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CampaignKeeperSite.Startup))]
namespace CampaignKeeperSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}

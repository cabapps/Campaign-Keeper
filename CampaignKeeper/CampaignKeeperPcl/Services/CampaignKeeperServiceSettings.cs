using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Services
{
    public class CampaignKeeperServiceSettings
    {
        public static Uri ApiBaseUri { get; set; }
        public static string LocationsPath { get; set; }
        public static string CampaignsPath { get; set; }

        public CampaignKeeperServiceSettings() { }
    }
}

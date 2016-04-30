using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Services
{
    public class CampaignKeeperServiceSettings
    {
        public Uri ApiBaseUri { get; private set; }
        public string LocationsPath { get; set; }

        public CampaignKeeperServiceSettings()
        {
            ApiBaseUri = new Uri(@"http://localhost:26513/");
            LocationsPath = @"api/Locations";
        }
    }
}

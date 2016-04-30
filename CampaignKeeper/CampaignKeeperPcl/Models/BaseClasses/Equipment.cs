using CampaignKeeperPcl.Locations.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl
{
    public abstract class Equipment : Good
    {
        public decimal Weight { get; set; }
    }
}

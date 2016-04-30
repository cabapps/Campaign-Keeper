using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Settlements
{
    public class Town : Settlement
    {
        public List<Store> Stores { get; set; }
    }
}

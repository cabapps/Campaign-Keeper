using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Waterbodies
{
    public class Lake : Waterbody
    {
        public List<Region> BorderRegions { get; set; }
    }
}

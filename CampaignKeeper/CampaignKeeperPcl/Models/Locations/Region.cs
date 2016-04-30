using CampaignKeeperPcl.Locations.Landforms;
using CampaignKeeperPcl.Locations.Settlements;
using CampaignKeeperPcl.Locations.Waterbodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    public class Region : Location
    {        
        public List<River> Rivers { get; set; }
        public List<Lake> Lakes { get; set; }
        public List<Mountain> Mountains { get; set; }
        public List<Woodland> Woodlands { get; set; }
        public List<Hill> Hills { get; set; }
    }
}

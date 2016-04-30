using CampaignKeeperPcl.Organizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    public abstract class Settlement : Location
    {
        public int Population { get; set; }
        public Npc Ruler { get; set; }
        public List<Organization> Organizations { get; set; }
    }
}

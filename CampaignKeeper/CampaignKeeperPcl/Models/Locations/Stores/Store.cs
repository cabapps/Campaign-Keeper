using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    public abstract class Store : Location
    {
        public Npc Owner { get; set; }
    }
}

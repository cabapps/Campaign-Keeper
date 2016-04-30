using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    public abstract class Waterbody : Location
    {
        public int Depth { get; set; }
        public List<Settlement> Harbors { get; set; }
    }
}

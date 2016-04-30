using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Landforms
{
    public class Mountain : Landform
    {
        public bool IsVolcanic { get; set; }
        public bool IsPassable { get; set; }
    }
}

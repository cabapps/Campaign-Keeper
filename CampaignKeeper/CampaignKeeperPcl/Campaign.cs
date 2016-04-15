using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampaignKeeperPcl
{
    public class Campaign : NamedItem
    {
        public List<Location> Locations { get; set; }        
    }
}

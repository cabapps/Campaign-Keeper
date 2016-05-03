using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampaignKeeperPcl
{
    public class Campaign : NamedItem
    {
        public List<Location> Locations { get; set; }
        public string Theme { get; set; }
        public string Description { get; set; }
    }
}

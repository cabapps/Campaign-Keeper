using CampaignKeeperPcl.Locations.Settlements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Countries
{
    public class SettledRegion : Region
    {
        public Npc Ruler { get; set; }
        public List<City> Cities { get; set; }
        public List<Town> Towns { get; set; }
        public List<Village> Villages { get; set; }
    }
}

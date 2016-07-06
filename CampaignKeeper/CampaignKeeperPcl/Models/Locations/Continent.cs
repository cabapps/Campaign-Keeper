using CampaignKeeperPcl.Models.Cultures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    public class Continent : Location
    {
        public List<Country> Countries { get; set; }
        public List<Region> UnsettledRegions { get; set; }
        public List<EthnicGroup> EthnicGroups { get; set; }
    }
}

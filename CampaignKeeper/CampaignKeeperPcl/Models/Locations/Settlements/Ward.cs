using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Settlements
{
    public class Ward : Settlement
    {
        public EconomicStatus EconomicStatus { get; set; }
        public CrimeStatus CrimeStatus { get; set; }
        public List<Store> Stores { get; set; }
    }
}

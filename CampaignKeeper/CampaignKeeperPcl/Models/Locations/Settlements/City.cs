using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Settlements
{
    public class City : Settlement
    {
        public List<Ward> Wards { get; set; }
    }
}

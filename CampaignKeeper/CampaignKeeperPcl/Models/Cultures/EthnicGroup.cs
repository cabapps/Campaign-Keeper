using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Models.Cultures
{
    public class EthnicGroup : NamedItem
    {
        public Culture Culture { get; set; }
        public string PhysicalTraits { get; set; }
        public string History { get; set; }
    }
}

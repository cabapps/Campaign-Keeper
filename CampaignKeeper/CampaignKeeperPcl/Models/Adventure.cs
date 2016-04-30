using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl
{
    public class Adventure : NamedItem
    {
        public List<CampaignEvent> Events { get; set; }
    }
}

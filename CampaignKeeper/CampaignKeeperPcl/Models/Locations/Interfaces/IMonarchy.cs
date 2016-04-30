using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    interface IMonarchy
    {
        Npc Monarch { get; set; }
        IList<Npc> RoyalFamily { get; set; }
        IList<Npc> Nobles { get; set; }
    }
}

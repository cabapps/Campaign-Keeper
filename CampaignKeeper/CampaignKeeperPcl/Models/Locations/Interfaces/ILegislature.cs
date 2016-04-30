using CampaignKeeperPcl.Locations.Countries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    interface ILegislature
    {
        IList<Legislature> Legislatures { get; set; }
    }
}

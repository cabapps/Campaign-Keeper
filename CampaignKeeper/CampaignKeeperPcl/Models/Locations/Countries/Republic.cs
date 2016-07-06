using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Countries
{
    public class Republic : Country, ILegislature
    {
        public IList<Legislature> Legislatures { get; set; }
    }
}

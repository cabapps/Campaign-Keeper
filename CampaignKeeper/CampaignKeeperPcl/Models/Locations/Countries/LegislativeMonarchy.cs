using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Countries
{
    public class LegislativeMonarchy : Country, IMonarchy, ILegislature, IGoverned
    {
        public GovernmentForm GovernmentForm
        {
            get
            {
                return GovernmentForm.Monarchy;
            }
        }

        public string GovernmentFormName
        {
            get
            {
                return GovernmentForm.Monarchy.ToString();
            }
        }

        public IList<Legislature> Legislatures { get; set; }

        public Npc Monarch { get; set; }

        public IList<Npc> Nobles { get; set; }

        public IList<Npc> RoyalFamily { get; set; }
    }
}

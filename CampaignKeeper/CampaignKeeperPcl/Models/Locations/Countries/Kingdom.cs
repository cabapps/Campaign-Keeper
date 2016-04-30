using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Countries
{
    public class Kingdom : Country, IGoverned
    {
        public Npc Monarch { get; set; }
        public IList<Npc> RoyalFamily { get; set; }
        public IList<Npc> Nobles { get; set; }

        public string GovernmentFormName
        {
            get
            {
                return GovernmentForm.Autocracy.ToString();
            }
        }

        public GovernmentForm GovernmentForm
        {
            get
            {
                return GovernmentForm.Autocracy;
            }
        }
    }
}

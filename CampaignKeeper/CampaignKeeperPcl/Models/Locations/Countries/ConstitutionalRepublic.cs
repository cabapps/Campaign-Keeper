using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations.Countries
{
    public class ConstitutionalRepublic : Republic, IConstitution
    {
        public string Constitution { get; set; }
    }
}

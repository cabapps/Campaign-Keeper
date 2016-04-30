using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    public interface IGoverned
    {
        string GovernmentFormName { get; }
        GovernmentForm GovernmentForm { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Weapons
{
    public interface IRange
    {
        int NormalRange { get; set; }
        int MaximumRange { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Weapons
{
    public class Thrown : WeaponProperty, IRange
    {
        public int NormalRange { get; set; }
        public int MaximumRange { get; set; }
    }
}

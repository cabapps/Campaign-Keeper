using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Weapons
{
    public class Weapon : Equipment
    {
        public WeaponType WeaponType { get; set; }
        public RangeType RangeType { get; set; }
        public string Damage { get; set; }
        public List<WeaponProperty> Properties { get; set; }
    }
}

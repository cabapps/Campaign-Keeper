using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Armors
{
    public class HeavyArmor : Armor
    {
        public override int TotalArmorClass
        {
            get
            {
                return ArmorClass;
            }
        }
        public override string Don
        {
            get
            {
                return "10 minutes";
            }
        }

        public override string Doff
        {
            get
            {
                return "5 minutes";
            }
        }

        public int RequiredStrength { get; set; }

        public bool IsSpeedPenalized(int strength) => strength < RequiredStrength;

    }
}

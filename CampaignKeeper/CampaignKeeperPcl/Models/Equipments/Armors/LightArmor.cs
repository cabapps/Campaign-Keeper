using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Armors
{
    public class LightArmor : Armor
    {
        public int DexModifier { get; set; }

        public override int TotalArmorClass
        {
            get
            {
                return ArmorClass + DexModifier;
            }
        }

        public override string Don
        {
            get
            {
                return "1 minute";
            }
        }

        public override string Doff
        {
            get
            {
                return "1 minute";
            }
        }

    }
}

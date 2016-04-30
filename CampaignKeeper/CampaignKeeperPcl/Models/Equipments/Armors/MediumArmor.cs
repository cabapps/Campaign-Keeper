using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Armors
{
    public class MediumArmor : Armor
    {
        private int dexModifier;

        public int DexModifier
        {
            get
            {
                return dexModifier > 2 ? 2 : dexModifier;
            }
            set
            {
                dexModifier = value > 2 ? 2 : value;
            }                    
        }

        public override int TotalArmorClass
        {
            get
            {
                return DexModifier + ArmorClass;
            }
        }

        public override string Don
        {
            get
            {
                return "5 minutes";
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

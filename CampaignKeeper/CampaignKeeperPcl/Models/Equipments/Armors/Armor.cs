using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Armors
{
    public abstract class Armor : Equipment
    {
        protected bool isStealthDisadvantage;

        internal int ArmorClass { get; set; }
        public abstract int TotalArmorClass { get; }
        public bool IsStealthDisadvantage { get; internal set; }
        public abstract string Don { get; }
        public abstract string Doff { get; }
    }
}

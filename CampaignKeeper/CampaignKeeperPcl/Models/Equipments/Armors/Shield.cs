using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Equipments.Armors
{
    public class Shield : Equipment
    {
        public int ArmorBonus { get; set; }
        public string Don { get { return "1 action"; } }
        public string Doff { get { return "1 action"; } }
    }
}

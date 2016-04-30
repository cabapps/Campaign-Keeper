using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl
{
    public abstract class Character : NamedItem
    {
        public string History { get; set; }
        public string Appearance { get; set; }
        public string Bond { get; set; }
        public string Ideal { get; set; }
        public string Flaw { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Organizations
{
    public class Organization : NamedItem
    {
        public string Motto { get; set; }
        public List<string> Beliefs { get; set; }
        public List<string> Goals { get; set; }
        public List<string> Quests { get; set; }
        public List<Rank> Ranks { get; set; }
    }
}

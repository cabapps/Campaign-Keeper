
using System.Runtime.Serialization;

namespace CampaignKeeperPcl
{
    public abstract class Location : NamedItem
    {        
        public string Map { get; set; }
        [DataMember(IsRequired = true)]
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}
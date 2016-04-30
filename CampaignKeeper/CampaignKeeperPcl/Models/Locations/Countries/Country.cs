using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.Locations
{
    public abstract class Country : Location
    {
        public List<Region> Regions { get; set; }
        public List<Ocean> BorderOceans { get; set; }
        public List<Country> BorderCountries { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
    }
}

using CampaignKeeperPcl.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels.LocationViewModels
{
    public class RegionViewModel : LocationViewModel
    {
        public Region Region { get { return location as Region; } set { location = value; OnPropertyChanged(); } }

        public RegionViewModel()
        {

        }

        public RegionViewModel(Region region)
        {
            Region = region;
        }

        public override async Task Save()
        {
            await base.Save();
            Message = "Region saved!";
        }
    }
}

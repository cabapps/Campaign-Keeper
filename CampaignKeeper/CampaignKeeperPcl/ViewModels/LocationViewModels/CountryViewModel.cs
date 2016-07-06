using CampaignKeeperPcl.Locations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels.LocationViewModels
{
    public class CountryViewModel : LocationViewModel
    {
        public Country Country { get { return location as Country; } set { location = value; OnPropertyChanged(); } }

        public CountryViewModel()
        {

        }

        public CountryViewModel(Country country)
        {
            Country = country;
        }

        public override async Task Save()
        {
            await base.Save();
            Message = "Country saved!";
        }
    }
}

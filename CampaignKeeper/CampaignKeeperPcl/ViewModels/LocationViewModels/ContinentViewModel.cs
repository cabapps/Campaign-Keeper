using CampaignKeeperPcl.Locations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels.LocationViewModels
{
    public class ContinentViewModel : LocationViewModel
    {
        #region Fields
        private ObservableCollection<CountryViewModel> countries;
        #endregion

        #region Properties
        public ObservableCollection<CountryViewModel> Countries { get { return countries; } set { countries = value; OnPropertyChanged(); } }
        public Continent Continent { get { return location as Continent; } set { location = value; OnPropertyChanged(); } }
        #endregion

        public ContinentViewModel()
        {
            countries = new ObservableCollection<CountryViewModel>();
        }

        public ContinentViewModel(Continent continent)
        {
            countries = new ObservableCollection<CountryViewModel>();
            Continent = continent;
            if (continent.Countries?.Count > 0)
            {
                foreach (var country in continent.Countries)
                {
                    Countries.Add(new CountryViewModel(country));
                }
            }            
        }
        
        public override async Task Save()
        {
            await base.Save();
            Message = "Continent saved.";
        }
    }
}

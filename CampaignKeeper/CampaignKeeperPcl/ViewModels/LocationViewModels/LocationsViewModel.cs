using CampaignKeeperPcl.Locations;
using CampaignKeeperPcl.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels.LocationViewModels
{
    public class LocationsViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<ContinentViewModel> continents;
        private ObservableCollection<CountryViewModel> countries;
        private ObservableCollection<RegionViewModel> regions;
        private int campaignId;

        private bool showContinents;
        private bool showCountries;
        private bool showRegions;
        private bool showLocationDetail;
        #endregion

        #region Properties
        public ObservableCollection<ContinentViewModel> Continents { get { return continents; } set { continents = value; OnPropertyChanged(); } }
        public ObservableCollection<CountryViewModel> Countries { get { return countries; } set { countries = value; OnPropertyChanged(); } }
        public ObservableCollection<RegionViewModel> Regions { get { return regions; } set { regions = value; OnPropertyChanged(); } }

        public bool ShowContinents { get { return showContinents; } set { showContinents = value; OnPropertyChanged(); } }
        public bool ShowCountries { get { return showCountries; } set { showCountries = value; OnPropertyChanged(); } }
        public bool ShowRegions { get { return showRegions; } set { showRegions = value; OnPropertyChanged(); } }
        public bool ShowLocationDetail { get { return showLocationDetail; } set { showLocationDetail = value; OnPropertyChanged(); } }
        #endregion

        public LocationsViewModel()
        {
            continents = new ObservableCollection<ContinentViewModel>();
            countries = new ObservableCollection<CountryViewModel>();
            regions = new ObservableCollection<RegionViewModel>();
        }

        public LocationsViewModel(Campaign campaign) : base()
        {
            campaignId = campaign.Id;
            continents = new ObservableCollection<ContinentViewModel>();
            countries = new ObservableCollection<CountryViewModel>();
            regions = new ObservableCollection<RegionViewModel>();
        }

        public LocationsViewModel(Location location) : base()
        {
            campaignId = location.CampaignId;
            continents = new ObservableCollection<ContinentViewModel>();
            countries = new ObservableCollection<CountryViewModel>();
            regions = new ObservableCollection<RegionViewModel>();
        }

        public async Task LoadContinents()
        {
            await HideLocationViews();
            var result = await Service.GetItems<Continent>(CampaignKeeperServiceSettings.LocationsPath);
            if (result == null)
            {
                foreach (var message in Service.Messages)
                {
                    Message += $"{message} ";
                }
                return;
            }
            Continents.Clear();
            foreach (var continent in result)
            {
                Continents.Add(new ContinentViewModel(continent));
            }
            ShowContinents = true;
            ShowLocationDetail = true;
        }

        public async Task LoadCountries()
        {
            await HideLocationViews();
            var result = await Service.GetItems<Country>(CampaignKeeperServiceSettings.LocationsPath);
            if (result == null)
            {
                foreach (var message in Service.Messages)
                {
                    Message += $"{message} ";
                }
                return;
            }
            Continents.Clear();
            foreach (var country in result)
            {
                Countries.Add(new CountryViewModel(country));
            }
            ShowCountries = true;
        }

        public async Task LoadRegions()
        {
            await HideLocationViews();
            var result = await Service.GetItems<Region>(CampaignKeeperServiceSettings.LocationsPath);
            if (result == null)
            {
                foreach (var message in Service.Messages)
                {
                    Message += $"{message} ";
                }
                return;
            }
            Regions.Clear();
            foreach (var region in result)
            {
                Regions.Add(new RegionViewModel(region));
            }
            ShowRegions = true;
        }

        public async Task HideLocationViews()
        {
            ShowLocationDetail = false;
            ShowContinents = false;
            ShowCountries = false;
            ShowRegions = false;
        }

        public async Task AddNewLocation()
        {
            if (ShowContinents)
            {
                Continents.Add(new ContinentViewModel(new Continent() { CampaignId = campaignId, Name = "New Location" }));
            }
            else if (ShowCountries)
            {
                Countries.Add(new CountryViewModel(new Country() { CampaignId = campaignId, Name = "New Location" }));
            }
            else if (ShowRegions)
            {
                Regions.Add(new RegionViewModel(new Region() { CampaignId = campaignId, Name = "New Location" }));
            }
            ShowLocationDetail = true;
        }
    }
}

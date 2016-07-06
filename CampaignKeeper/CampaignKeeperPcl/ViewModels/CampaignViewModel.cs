using CampaignKeeperPcl.Services;
using CampaignKeeperPcl.ViewModels.LocationViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels
{
    public class CampaignViewModel : ItemViewModel
    {

        #region Fields                
        private Campaign campaign;
        private LocationsViewModel locationsViewModel;
        private bool showLocationsView;
        #endregion

        #region Propoerties        
        public Campaign Campaign { get { return campaign; } set { campaign = value; OnPropertyChanged(); } }
        public LocationsViewModel LocationsViewModel { get { return locationsViewModel; } set { locationsViewModel = value; OnPropertyChanged(); } }
        public bool ShowLocationsView { get { return showLocationsView; } set { showLocationsView = value; OnPropertyChanged(); } }
        #endregion

        public CampaignViewModel() : base()
        {
            Campaign = new Campaign();
            LocationsViewModel = new LocationsViewModel();
        }

        public CampaignViewModel(Campaign campaign)
        {
            Campaign = campaign;
            EnableEditMode(campaign?.Id == 0);
            LocationsViewModel = new LocationsViewModel();
        }

        public override void EnableEditMode(bool enable)
        {            
            CanDelete = enable && campaign.Id != 0;
            CanSave = enable;
            CanEdit = !enable;
        }

        public override async Task Save()
        {
            if (Campaign.Id == 0)
            {
                await Service.Post(Campaign, CampaignKeeperServiceSettings.CampaignsPath);
            }
            else
            {
                await Service.Put(Campaign, CampaignKeeperServiceSettings.CampaignsPath);
            }            
            Message = "Campaign Saved";
        }

        public override async Task Delete()
        {
            if (Campaign.Id != 0)
            {
                await Service.Delete(Campaign, CampaignKeeperServiceSettings.CampaignsPath);
            }
        }

        public async Task LoadLocations()
        {
            await HideViews();
            LocationsViewModel = new LocationsViewModel(Campaign);
            ShowLocationsView = true;
        }

        public async Task HideViews()
        {
            ShowLocationsView = false;
            await LocationsViewModel.HideLocationViews();
        }
    }
}

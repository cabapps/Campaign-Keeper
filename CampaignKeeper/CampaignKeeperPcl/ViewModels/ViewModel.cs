using CampaignKeeperPcl.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels
{
    public class ViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<CampaignViewModel> campaigns;
        private bool showCampaignDetail;
        private bool showCampaignsView;
        private bool showLocationsView;
        #endregion

        #region Properties
        public ObservableCollection<CampaignViewModel> Campaigns { get { return campaigns; } set { campaigns = value; OnPropertyChanged(); } }
        public bool ShowCampaignDetail { get { return showCampaignDetail; } set { showCampaignDetail = value; OnPropertyChanged(); } }
        public bool ShowCampignsView { get { return showCampaignsView; } set { showCampaignsView = value; OnPropertyChanged(); } }
        public bool ShowLocationsView { get { return showLocationsView; } set { showLocationsView = value; OnPropertyChanged(); } }
        #endregion

        public ViewModel() : base()
        {
            campaigns = new ObservableCollection<CampaignViewModel>();
        }

        public async Task LoadCampaigns()
        {
            var result = await Service.GetItems<Campaign>(CampaignKeeperServiceSettings.CampaignsPath);
            if (result == null)
            {
                foreach (var message in Service.Messages)
                {
                    Messages.Add(message);
                }
                return;
            }
            Campaigns.Clear();
            foreach (var campaign in result)
            {
                Campaigns.Add(new CampaignViewModel(campaign));
            }
        }

        public void AddNewCampaign()
        {
            Campaigns.Add(new CampaignViewModel(new Campaign { Name = "New Campaign" }));
            Campaigns.OrderBy(c => c.Campaign.Id);
        }
        
        
        public void HideViews()
        {
            ShowCampignsView = false;
            ShowLocationsView = false;
        }        
    }
}

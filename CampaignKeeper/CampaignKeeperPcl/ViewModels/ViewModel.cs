using CampaignKeeperPcl.Locations;
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
    public class ViewModel : BaseViewModel
    {
        #region Fields
        private ObservableCollection<CampaignViewModel> campaigns;        
        
        private bool showCampaignDetail;
        private bool showCampaignsView;        
        #endregion

        #region Properties
        
        public ObservableCollection<CampaignViewModel> Campaigns { get { return campaigns; } set { campaigns = value; OnPropertyChanged(); } }        
        public bool ShowCampaignDetail { get { return showCampaignDetail; } set { showCampaignDetail = value; OnPropertyChanged(); } }
        public bool ShowCampaignsView { get { return showCampaignsView; } set { showCampaignsView = value; OnPropertyChanged(); } }
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
                    Message += $"{message} ";
                }
                return;
            }
            Campaigns.Clear();
            foreach (var campaign in result)
            {
                Campaigns.Add(new CampaignViewModel(campaign));
            }
        }

        public async Task AddNewCampaign()
        {
            Campaigns.Add(new CampaignViewModel(new Campaign { Name = "New Campaign" }));
            Campaigns.OrderBy(c => c.Campaign.Id);
            ShowCampaignDetail = true;
        }
        
        
        public async Task HideViews()
        {
            ShowCampaignsView = false;
            Campaigns.Select(async c  => { await c.HideViews(); return c; }).ToList();
        }
        
                
    }
}

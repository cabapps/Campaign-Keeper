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
    public class CampaignViewModel : BaseViewModel
    {

        #region Fields        
        private bool canSave;
        private Campaign campaign;
        private bool canDelete;
        private bool canEdit;
        #endregion

        #region Propoerties
        public bool CanSave { get { return canSave; } set { canSave = value; OnPropertyChanged(); } }
        public bool CanDelete { get { return canDelete; } set { canDelete = value; OnPropertyChanged(); } }
        public bool CanEdit { get { return canEdit; } set { canEdit = value; OnPropertyChanged(); } }
        public Campaign Campaign { get { return campaign; } set { campaign = value; OnPropertyChanged(); } }
        #endregion

        public CampaignViewModel() : base() { }

        public CampaignViewModel(Campaign campaign)
        {
            Campaign = campaign;
            EnableEditMode(campaign?.Id == 0);            
        }

        public void EnableEditMode(bool enable)
        {            
            CanDelete = enable && campaign.Id != 0;
            CanSave = enable;
            CanEdit = !enable;
        }

        public async Task Save()
        {
            if (Campaign.Id == 0)
            {
                await Service.Post(Campaign, CampaignKeeperServiceSettings.CampaignsPath);
            }
            else
            {
                await Service.Put(Campaign, CampaignKeeperServiceSettings.CampaignsPath);
            }            
            Messages.Add("Campaign Saved");
        }

        public async Task Delete()
        {
            if (Campaign.Id != 0)
            {
                await Service.Delete(Campaign, CampaignKeeperServiceSettings.CampaignsPath);
            }
        }
    }
}

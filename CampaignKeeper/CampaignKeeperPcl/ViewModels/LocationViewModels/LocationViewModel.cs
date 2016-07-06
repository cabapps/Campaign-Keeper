using CampaignKeeperPcl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels
{
    public abstract class LocationViewModel : ItemViewModel
    {
        #region Fields
        protected Location location;
        #endregion        

        public LocationViewModel() : base() { }

        public override void EnableEditMode(bool enable)
        {
            CanEdit = !enable;
            CanSave = enable;
            CanDelete = enable && location.Id != 0;
        }

        public override async Task Save()
        {
            if (location.Id == 0)
            {
                await Service.Post(location, CampaignKeeperServiceSettings.LocationsPath);
            }
            else
            {
                await Service.Put(location, CampaignKeeperServiceSettings.LocationsPath);
            }
        }

        public override async Task Delete()
        {
            if (location.Id != 0)
            {
                await Service.Delete(location, CampaignKeeperServiceSettings.LocationsPath);
            }
        }
    }
}

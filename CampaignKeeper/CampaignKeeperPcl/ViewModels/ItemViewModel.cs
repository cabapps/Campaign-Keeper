using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels
{
    public abstract class ItemViewModel : BaseViewModel
    {
        private bool canDelete;
        private bool canEdit;
        private bool canSave;

        public bool CanSave { get { return canSave; } set { canSave = value; OnPropertyChanged(); } }
        public bool CanDelete { get { return canDelete; } set { canDelete = value; OnPropertyChanged(); } }
        public bool CanEdit { get { return canEdit; } set { canEdit = value; OnPropertyChanged(); } }

        public abstract void EnableEditMode(bool enable);

        public abstract Task Save();

        public abstract Task Delete();
    }
}

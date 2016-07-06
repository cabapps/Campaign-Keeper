using CampaignKeeperPcl;
using CampaignKeeperPcl.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CampaignKeeperUniversal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private CampaignViewModel selectedCampaign;

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                base.OnNavigatedTo(e);
                DataContext = App.ViewModel;
                await LoadCampaignView();
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
            
        }

        private async Task LoadCampaignView()
        {
            await App.ViewModel.LoadCampaigns();
            await App.ViewModel.HideViews();
            App.ViewModel.ShowCampaignsView = true;
            if (App.ViewModel.Campaigns.Count > 0)
            {
                CampaignCollection.View.MoveCurrentToFirst();
                App.ViewModel.ShowCampaignDetail = true;                
            }
        }

        private async void AddCampaign_Click(object sender, RoutedEventArgs e)
        {
            await App.ViewModel.AddNewCampaign();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (CampaignCollection.View.CurrentItem is CampaignViewModel)
            {
                var campaign = CampaignCollection.View.CurrentItem as ItemViewModel;
                campaign.EnableEditMode(true);
            }
        }

        private async void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (App.ViewModel.ShowCampaignsView)
                {
                    await SaveItem(CampaignCollection.View.CurrentItem as ItemViewModel);
                    await LoadCampaignView();
                }
            }
            catch (Exception ex)
            {
                App.ViewModel.Message = ex.Message;
            }
            
        }

        private async Task SaveItem(ItemViewModel itemViewModel)
        {
            if (itemViewModel == null)
            {
                return;
            }
            await itemViewModel.Save();
            itemViewModel.EnableEditMode(false);
        }

        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sender is Button && CampaignCollection.View.CurrentItem is ItemViewModel)
                {
                    var campaign = CampaignCollection.View.CurrentItem as ItemViewModel;
                    await campaign.Delete();
                    await LoadCampaignView();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        private async void CampaignsButton_Click(object sender, RoutedEventArgs e)
        {
            await App.ViewModel.HideViews();
            App.ViewModel.ShowCampaignsView = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button && CampaignCollection.View.CurrentItem is ItemViewModel)
            {
                var campaign = CampaignCollection.View.CurrentItem as ItemViewModel;
                campaign.EnableEditMode(false);
            }
        }

        private async void AddLocation_Click(object sender, RoutedEventArgs e)
        {
            if (CampaignCollection.View.CurrentItem is CampaignViewModel)
            {
                var campaignViewModel = (CampaignViewModel)CampaignCollection.View.CurrentItem;
                await campaignViewModel.LocationsViewModel.AddNewLocation();
            }
        }

        private async void LocationsButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (CampaignCollection.View.CurrentItem is CampaignViewModel)
            {
                await App.ViewModel.HideViews();
                var campaignViewModel = (CampaignViewModel)CampaignCollection.View.CurrentItem;
                await campaignViewModel.LoadLocations();
                if (campaignViewModel.LocationsViewModel.Continents.Count == 0
                && campaignViewModel.LocationsViewModel.Countries.Count == 0)
                {
                    await campaignViewModel.LocationsViewModel.LoadContinents();
                }
            }
                
        }

        private async void ContinentsButton_Checked(object sender, RoutedEventArgs e)
        {
            if (CampaignCollection.View.CurrentItem is CampaignViewModel)
            {
                var campaignViewModel = (CampaignViewModel)CampaignCollection.View.CurrentItem;
                await campaignViewModel.LocationsViewModel.LoadContinents();
            }
        }

        private async void CountriesButton_Checked(object sender, RoutedEventArgs e)
        {
            if (CampaignCollection.View.CurrentItem is CampaignViewModel)
            {
                var campaignViewModel = (CampaignViewModel)CampaignCollection.View.CurrentItem;
                await campaignViewModel.LocationsViewModel.LoadCountries();
            }
        }

        private async void RegionsButton_Checked(object sender, RoutedEventArgs e)
        {
            if (CampaignCollection.View.CurrentItem is CampaignViewModel)
            {
                var campaignViewModel = (CampaignViewModel)CampaignCollection.View.CurrentItem;
                await campaignViewModel.LocationsViewModel.LoadRegions();
            }
        }
    }
}

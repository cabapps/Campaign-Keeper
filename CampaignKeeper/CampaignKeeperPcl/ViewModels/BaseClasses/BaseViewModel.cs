﻿using CampaignKeeperPcl.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CampaignKeeperPcl.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        #endregion

        #region Fields        
        private string messages;
        #endregion

        #region Properties
        public string Message { get { return messages; } set { messages = value; OnPropertyChanged(nameof(Message)); } }
        protected CampaignKeeperService Service { get; set; }
        #endregion

        public BaseViewModel()
        {
            messages = string.Empty;
            Service = new CampaignKeeperService();
        }


    }
}

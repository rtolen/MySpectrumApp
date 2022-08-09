using System;
using Xamarin.Forms;
using MySpectrumApp.Interfaces;

namespace MySpectrumApp.ViewModels
{
    public class PlatformSpecificViewModel : BaseViewModel
    {
        private string version;
        private string description;
        public PlatformSpecificViewModel() 
        {
            Title = "Platform Specific Info";
            Description = "test";
            IPlatform platformInfo = DependencyService.Get<IPlatform>();
            Description = platformInfo.GetModel();
            Version = platformInfo.GetVersion();     


        }



        public string Version
        {
            get => version;
            set => SetProperty(ref version, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }


    }
}
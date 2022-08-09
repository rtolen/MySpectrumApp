using MySpectrumApp.ViewModels;
using MySpectrumApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MySpectrumApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(PlatformSpecific), typeof(PlatformSpecific));
        }

    }
}

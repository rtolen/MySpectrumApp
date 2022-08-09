using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySpectrumApp.ViewModels;

namespace MySpectrumApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlatformSpecific : ContentPage
    {
        PlatformSpecificViewModel _viewModel;
        public PlatformSpecific()
        {
            try
            {
                InitializeComponent();
                this.BindingContext = new PlatformSpecificViewModel();
            }
            catch(Exception e)
            {

            }
        }

        protected override void OnAppearing()
        {
            /*
            try
            {
                base.OnAppearing();
                _viewModel.OnAppearing();
            }
            catch(Exception e)
            {

            }
            */
        }
    }

   
}
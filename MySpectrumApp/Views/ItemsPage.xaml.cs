using MySpectrumApp.ViewModels;
using Xamarin.Forms;
using System.IO;
using System;

namespace MySpectrumApp.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;
        
        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
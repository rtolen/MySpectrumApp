using MySpectrumApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MySpectrumApp.ViewModels;
using MySpectrumApp.Models;
using System;

namespace MySpectrumApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        DetailViewModel _viewModel;
        public MainPage()
        {

            InitializeComponent();
            //this.BindingContext = new DetailViewModel();
            //nativeListView.Items = DataSource.GetList();
            nativeListView.Items = DataSource.GetList();

            
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushModalAsync(new DetailsPage(e.SelectedItem));
        }
        void OnItemClicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            nativeListView.Items = DataSource.GetList();
        }
        void OnItemClicked_Dir(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            nativeListView.Items = DataSource.GetList2();
        }
        void OnItemClicked_Coins(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            nativeListView.Items = DataSource.GetBitcoins();
        }
    }
}
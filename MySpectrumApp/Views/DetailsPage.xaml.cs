using System;
using MySpectrumApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySpectrumApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage(object detail)
        {
            InitializeComponent();
            if (detail is string)
            {
                detailLabel.Text = detail as string;
            }
            else if (detail is DataSource)
            {
                detailLabel.Text = (detail as DataSource).Name;
            }
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
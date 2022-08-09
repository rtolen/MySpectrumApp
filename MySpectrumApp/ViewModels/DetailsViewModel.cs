using System;
using Xamarin.Forms;
using MySpectrumApp.Models;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace MySpectrumApp.ViewModels
{
    public class DetailViewModel : ContentPage
    {
        string option2 = string.Empty;
        public string Option2
        {
            get { return option2; }
            set { SetProperty(ref option2, value); }
        }
        
        public DetailViewModel(object detail)
        {
            Title = "List Page";
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(20, 40, 20, 20);
                    break;
                case Device.Android:
                case Device.UWP:
                    Padding = new Thickness(20);
                    break;
            }

            var detailLabel = new Label();
            if (detail is string)
            {
                detailLabel.Text = detail as string;
            }
            else if (detail is DataSource)
            {
                detailLabel.Text = (detail as DataSource).Name +"  " + (detail as DataSource).Category;
            }

            var dismissButton = new Button { Text = "Dismiss" };
            dismissButton.Clicked += OnButtonClicked;

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label { Text = "Xamarin.Forms Detail Page" },
                    detailLabel,
                    dismissButton
                }
            };
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}

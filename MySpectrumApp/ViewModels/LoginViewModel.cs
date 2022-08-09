using MySpectrumApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MySpectrumApp;

namespace MySpectrumApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            try
            {
                //await Shell.Current.GoToAsync($"//{nameof(AppShell)}");

                Application.Current.MainPage = new AppShell();
            }
            catch (Exception ex)
            { 
            }
        }
    }
}

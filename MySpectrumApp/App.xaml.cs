using MySpectrumApp.Services;
using MySpectrumApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MySpectrumApp
{
    public partial class App : Application
    {
        public static string Description { get; set; }
        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
            //MainPage = new AppShell();
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

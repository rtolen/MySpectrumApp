using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.IO;

namespace MySpectrumApp.ViewModels
{
    public class ListViewModel : BaseViewModel
    {
        private string directory;
        public ListViewModel()
        {
            //string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            Title = "List Page";
            Directory = filePath;
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public string Directory
        {
            get => directory;
            set => SetProperty(ref directory, value);
        }

        public ICommand OpenWebCommand { get; }
    }
}
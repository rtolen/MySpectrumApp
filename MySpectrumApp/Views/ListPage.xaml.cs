using System;
using System.ComponentModel;
using Xamarin.Forms;
using MySpectrumApp.ViewModels;

namespace MySpectrumApp.Views
{
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            this.BindingContext = new ListViewModel();
        }
    }
}
using PhasmoApp.Services;
using PhasmoApp.ViewModels;
using PhasmoApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PhasmoApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            // await Shell.Current.GoToAsync("//LoginPage");

            DependencyService.Get<ICloseApplication>().closeApplication();
        }
    }
}

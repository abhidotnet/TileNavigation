using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using TileNavigation.Views;

namespace TileNavigation.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Navigation Page.";
            OpenWebCommand = new Command(async () => await Application.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LoginPage())));
        }

        public ICommand OpenWebCommand { get; }
    }
}
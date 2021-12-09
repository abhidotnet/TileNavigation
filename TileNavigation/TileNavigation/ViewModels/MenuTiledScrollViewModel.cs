using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using TileNavigation.Views;

namespace TileNavigation.ViewModels
{
    public class MenuTiledScrollViewModel : BaseViewModel
    {


        public ICommand GotoAssetSearch => new Command(PerformGotoAssetSearch);

        async void PerformGotoAssetSearch()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AssetSearchView());
            //await Shell.Current.GoToAsync("AssetSearch");
        }
    }
}

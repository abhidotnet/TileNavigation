using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using TileNavigation.ViewModels;
using TileNavigation.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TileNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssetSearchView : ContentPage
    {
        AssetSearchViewModel Asvm = new AssetSearchViewModel() {SearchGroupName="searchBy",SearchSelection="ByOrg" };
        public AssetSearchView()
        {
            InitializeComponent();
            searchResults.ItemsSource = DataService.assets;
            BindingContext = Asvm;
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            Debug.WriteLine(Asvm.SearchSelection);
            searchResults.ItemsSource = DataService.GetSearchResults(e.NewTextValue);

        }
    }
}
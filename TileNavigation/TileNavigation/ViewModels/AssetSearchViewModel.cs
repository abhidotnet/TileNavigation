using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using TileNavigation.Services;


namespace TileNavigation.ViewModels
{
    public class AssetSearchViewModel : BaseViewModel
    {
        public ICommand PerformSearch => new Command<string>((string query) =>
        {
            SearchResults = DataService.GetSearchResults(query);
        });

        List<Asset> searchResults = DataService.assets;
        public List<Asset> SearchResults
        {
            get
            {
                System.Diagnostics.Debug.WriteLine($"searchGroupName value is {searchGroupname}");
                System.Diagnostics.Debug.WriteLine($"searchGroupName value is {searchSelection}");
                return searchResults;
            }
            set
            {
                searchResults = value;
                OnPropertyChanged();
            }
        }
        string searchGroupname;
        object searchSelection;

        public string SearchGroupName
        {
            get => searchGroupname;
            set
            {
                searchGroupname = value;
                OnPropertyChanged();
            }
        }

        public object SearchSelection
        {
            get => searchSelection;
            set
            {
                searchSelection = value;
                OnPropertyChanged();
            }
        }
    }
    public class Asset
    {
        public int AssetId { get; set; }
        public string AssetClass { get; set; }
        public string Location { get; set; }
        public string SerialNumber { get; set; }
    }
}

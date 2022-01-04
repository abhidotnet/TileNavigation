using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using TileNavigation.Models;
using TileNavigation.Views;
using Xamarin.Forms;

namespace TileNavigation.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private int itemId;
        private string text;
        private string description;
        private string storageyard;
        private string boxsize;
        private bool bldgoverheight;
        private string stateseal;
        private string serialno;

        public int Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string Boxsize
        {
            get => boxsize;
            set => SetProperty(ref boxsize, value);
        }

        public string StorageYard
        {
            get => storageyard;
            set => SetProperty(ref storageyard, value);
        }

        public bool BldgOverHeight
        {
            get => bldgoverheight;
            set => SetProperty(ref bldgoverheight, value);
        }

        public string StateSeal
        {
            get => stateseal;
            set => SetProperty(ref stateseal, value);
        }

        public string SerialNo
        {
            get => serialno;
            set => SetProperty(ref serialno, value);
        }

        public int ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(int itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                StorageYard = item.StorageYard;
                Boxsize = item.BoxSize;
                SerialNo = item.SerialNo;
                StateSeal = item.StateSeal;

                
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        public ICommand GotoNext => new Command(GotoNextPage);

        private async void GotoNextPage()
        {
           await Shell.Current.GoToAsync($"{nameof(PrecheckPage)}");
            
        }


    }
}

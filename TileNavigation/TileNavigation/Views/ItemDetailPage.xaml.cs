using System.ComponentModel;
using TileNavigation.ViewModels;
using Xamarin.Forms;

namespace TileNavigation.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
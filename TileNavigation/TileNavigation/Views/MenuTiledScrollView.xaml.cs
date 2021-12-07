using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TileNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuTiledScrollView : ContentPage
    {
        public MenuTiledScrollView()
        {
            InitializeComponent();
        }
    }
}
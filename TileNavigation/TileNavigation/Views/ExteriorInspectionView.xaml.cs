using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TileNavigation.ViewModels;

namespace TileNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExteriorInspectionView : ContentPage
    {
        public ExteriorInspectionView()
        {
            InitializeComponent();
            BindingContext = new ExteriorInspectionViewModel();
        }
    }
}
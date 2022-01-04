using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileNavigation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TileNavigation.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrecheckPage : ContentPage
    {
        public PrecheckPage()
        {
            InitializeComponent();
            BindingContext = new PrecheckViewModel();
        }
        void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            PrecheckViewModel precheck = new PrecheckViewModel()
            {
                WaterYesNo = "Is Checked"
            };
        }
    }
}
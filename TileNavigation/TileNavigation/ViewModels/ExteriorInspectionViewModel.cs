using System;
using System.Collections.Generic;
using System.Text;
using TileNavigation.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace TileNavigation.ViewModels
{
    public class ExteriorInspectionViewModel : BaseViewModel
    {
        public ICommand GotoInterior => new Command(GotoInteriorPage);

        private async void GotoInteriorPage()
        {
            await Shell.Current.GoToAsync($"{nameof(InteriorInspectionView)}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TileNavigation.Views;
using Xamarin.Forms;

namespace TileNavigation.ViewModels
{
    public class PrecheckViewModel : BaseViewModel
    {
        private string wateryesno;
        public string WaterYesNo
        {
            get => wateryesno;
            set => SetProperty(ref wateryesno, value);
        }
        public ICommand GotoExterior => new Command(GotoExteriorPage);

        private async void GotoExteriorPage()
        {
            await Shell.Current.GoToAsync($"{nameof(ExteriorInspectionView)}");
        }
    }
}

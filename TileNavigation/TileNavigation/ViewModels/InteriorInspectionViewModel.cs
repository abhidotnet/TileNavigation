using System;
using System.Collections.Generic;
using System.Text;
using TileNavigation.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace TileNavigation.ViewModels
{
    public class  InteriorInspectionViewModel : BaseViewModel

    { 

    public ICommand GotoStandardCleaning => new Command(GotoStandardCleaningPage);

    private async void GotoStandardCleaningPage()
    {
        await Shell.Current.GoToAsync($"{nameof(StandardCleaningView)}");

    }
}
}

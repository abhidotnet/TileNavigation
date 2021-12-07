using System;
using TileNavigation.Services;
using TileNavigation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TileNavigation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

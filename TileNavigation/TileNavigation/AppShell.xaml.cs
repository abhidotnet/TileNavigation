using System;
using System.Collections.Generic;
using TileNavigation.ViewModels;
using TileNavigation.Views;
using Xamarin.Forms;

namespace TileNavigation
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(AssetSearch), typeof(AssetSearch));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(PrecheckPage), typeof(PrecheckPage));
            Routing.RegisterRoute(nameof(StandardCleaningView), typeof(StandardCleaningView));
            Routing.RegisterRoute(nameof(InteriorInspectionView), typeof(InteriorInspectionView));
            Routing.RegisterRoute(nameof(ExteriorInspectionView), typeof(ExteriorInspectionView));
        }

    }
}

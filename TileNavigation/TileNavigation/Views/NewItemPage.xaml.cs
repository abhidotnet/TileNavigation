using System;
using System.Collections.Generic;
using System.ComponentModel;
using TileNavigation.Models;
using TileNavigation.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TileNavigation.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}
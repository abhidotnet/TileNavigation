using System;
using System.Windows.Input;
using TileNavigation.Views;
using Xamarin.Forms;

namespace TileNavigation.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string StorageYard { get; set; }
        public string SerialNo { get; set; }
        public string StateSeal { get; set; }
        public string BoxSize { get; set; }
        public bool BldgOverHeight { get; set; }
    }
}
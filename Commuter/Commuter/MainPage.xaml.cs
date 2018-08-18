using System;
using System.Diagnostics;
using Plugin.Geolocator;
using Xamarin.Forms;

namespace Commuter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GpsBtn_OnClicked(object sender, EventArgs e)
        {
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 100;
                var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(20), null, true);

            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
               // throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Device.Location;
using Microsoft.Phone.Tasks;

namespace AurariaCampusAppSE
{
    public partial class GPSLocation : PhoneApplicationPage
    {
        GeoCoordinateWatcher gcw;

        public GPSLocation()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            gcw = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
            gcw.MovementThreshold = 20;
            gcw.StatusChanged += new EventHandler<GeoPositionStatusChangedEventArgs>(gcw_StatusChanged);
            gcw.Start();
        }

        private void gcw_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Status == GeoPositionStatus.Ready)
            {
                GeoCoordinate coord = gcw.Position.Location;
                String CurLatLocation = coord.Latitude.ToString("0.000");
                String CurLonLocation = coord.Longitude.ToString("0.000");
                latitude.Text = "Latitude: " + CurLatLocation;
                longitude.Text = "Longitude: " + CurLonLocation;
                //After you have the location, stop the service to conserve power
                gcw.Stop();

                //Open Web Browser to navigate to Google Map using the current location from GPS;
                WebBrowserTask WebBrowserTask = new WebBrowserTask();
                WebBrowserTask.Uri = new Uri("http://maps.google.com/maps?q=" + CurLatLocation + "," +
                    CurLonLocation);
                WebBrowserTask.Show();

            }
            if (e.Status == GeoPositionStatus.Disabled || e.Status == GeoPositionStatus.NoData)
            {
                latitude.Text = "GPS Disabled";
                longitude.Text = "Please turn on your Location Service (GPS) in the system setting.";
                gcw.Stop();
            }
        }

        private void TextBlock_DoubleTap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/CampusMapScreen.xaml", UriKind.Relative));
        }
    }
}
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
                latitude.Text = "Latitude: " + coord.Latitude.ToString("0.000");
                longitude.Text = "Longitude: " + coord.Longitude.ToString("0.000");
                //After you have the location, stop the service to conserve power
                gcw.Stop();
            }
            if (e.Status == GeoPositionStatus.Disabled || e.Status == GeoPositionStatus.NoData)
            {
                latitude.Text = "GPS Disabled";
                longitude.Text = "";
                gcw.Stop();
            }
        }
    }
}
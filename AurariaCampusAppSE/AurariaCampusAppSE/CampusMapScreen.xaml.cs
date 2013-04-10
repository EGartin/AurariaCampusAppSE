using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace AurariaCampusAppSE
{
    public partial class CampusMapScreen : PhoneApplicationPage
    {
        public CampusMapScreen()
        {
            InitializeComponent();
        }

        private void DetailMapButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("http://www.ahec.edu/campusmaps/CampusMap.pdf", UriKind.Relative));
        }

        private void MapByLocationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/GPSLocation.xaml", UriKind.Relative));
        }
    }
}
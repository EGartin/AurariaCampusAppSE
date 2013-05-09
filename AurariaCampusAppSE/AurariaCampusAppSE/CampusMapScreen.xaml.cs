using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

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
            WebBrowserTask WebBrowserTask = new WebBrowserTask();
            WebBrowserTask.Uri = new Uri("http://www.ahec.edu/campusmaps/CampusMap.pdf");
            WebBrowserTask.Show();

            //NavigationService.Navigate(
            //   new Uri("http://www.ahec.edu/campusmaps/CampusMap.pdf", UriKind.Relative));
        }

        private void MapByLocationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/GPSLocation.xaml", UriKind.Relative));
        }

        private void TextBlock_DoubleTap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/AurariaCampusScreen.xaml", UriKind.Relative));
        }
    }
}
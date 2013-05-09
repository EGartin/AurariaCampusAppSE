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
    public partial class AurariaCampusScreen : PhoneApplicationPage
    {
        public AurariaCampusScreen()
        {
            InitializeComponent();
        }

        private void SchoolButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/InstitutionsScreen.xaml", UriKind.Relative));
        }

        private void CMapButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("/CampusMapScreen.xaml", UriKind.Relative));
        }

        private void TextBlock_DoubleTap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/MainPage.xaml", UriKind.Relative));
        }

    }
}
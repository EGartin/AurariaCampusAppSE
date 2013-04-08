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
    public partial class InstitutationsScreen : PhoneApplicationPage
    {
        public InstitutationsScreen()
        {
            InitializeComponent();
        }

        private void CCDImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("http://www.ccd.edu/", UriKind.Relative));
        }

        private void MSUDImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("http://www.msudenver.edu", UriKind.Relative));
        }

        private void UCDImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(
               new Uri("http://www.ucdenver.edu", UriKind.Relative));
        }


    }
}
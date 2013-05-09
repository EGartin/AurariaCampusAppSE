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
    public partial class InstitutationsScreen : PhoneApplicationPage
    {
        public InstitutationsScreen()
        {
            InitializeComponent();
        }
        
        //Navigate to CCD Website when CCD Image is tapped
        private void CCDImage_Tap(object sender, RoutedEventArgs e)
        {
            WebBrowserTask WebBrowserTask = new WebBrowserTask();
            WebBrowserTask.Uri = new Uri("http://www.ccd.edu");
            WebBrowserTask.Show();

            //NavigationService.Navigate(
             //  new Uri("http://www.ccd.edu/", UriKind.Relative));
        }

        private void MSUDImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask WebBrowserTask = new WebBrowserTask();
            WebBrowserTask.Uri = new Uri("http://www.msudenver.edu");
            WebBrowserTask.Show();

            //NavigationService.Navigate(
            //   new Uri("http://www.msudenver.edu", UriKind.Relative));
        }

        private void UCDImage_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask WebBrowserTask = new WebBrowserTask();
            WebBrowserTask.Uri = new Uri("http://www.ucdenver.edu");
            WebBrowserTask.Show();

            //NavigationService.Navigate(
            //   new Uri("http://www.ucdenver.edu", UriKind.Relative));
        }

        private void TextBlock_DoubleTap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(
                new Uri("/AurariaCampusScreen.xaml", UriKind.Relative));
        }


    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace AurariaCampusAppSE
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(
               new Uri("/AurariaCampusScreen.xaml", UriKind.Relative));
        }

        private void Image_DoubleTap_1(object sender, GestureEventArgs e)
        {
            MessageBox.Show("Auraria Campus, Denver, CO USA");
        }
    }
}
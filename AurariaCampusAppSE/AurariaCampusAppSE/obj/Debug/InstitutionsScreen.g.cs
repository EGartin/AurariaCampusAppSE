﻿#pragma checksum "C:\Users\Chubby\Downloads\AurariaCampusAppSE-master\AurariaCampusAppSE-master\AurariaCampusAppSE\AurariaCampusAppSE\InstitutionsScreen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "75B86B757A4D9B7F511534E0649978E0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AurariaCampusAppSE {
    
    
    public partial class InstitutationsScreen : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Image CCDImage;
        
        internal System.Windows.Controls.Image MSUDImage;
        
        internal System.Windows.Controls.Image UCDImage;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AurariaCampusAppSE;component/InstitutionsScreen.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.CCDImage = ((System.Windows.Controls.Image)(this.FindName("CCDImage")));
            this.MSUDImage = ((System.Windows.Controls.Image)(this.FindName("MSUDImage")));
            this.UCDImage = ((System.Windows.Controls.Image)(this.FindName("UCDImage")));
        }
    }
}


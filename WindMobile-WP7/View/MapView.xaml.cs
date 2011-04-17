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
using Microsoft.Phone.Controls.Maps;
using Ch.Epix.WindMobile.WP7.ViewModel;
using Ch.Epix.WindMobile.WP7.Model;

namespace Ch.Epix.WindMobile.WP7.View
{
    public partial class MapView : PhoneApplicationPage
    {
        public MainViewModel ViewModel
        {
            get
            {
                return DataContext as MainViewModel;
            }
        }

        public MapView()
        {
            InitializeComponent();
            StationMap.CredentialsProvider = new ApplicationIdCredentialsProvider("Aru7Ud6JR_vLA3MC_Vof2xFOXVejAASIjZzfy5pZuh3OUWLGkwMj--c8GWkutwCj");
            StationMap.SetView(ViewModel.GeoCoordinateWatcher.Position.Location, 9.0d);

            //foreach (var station in ViewModel.StationInfoList)
            //{
            //    StationMap.Children.Add(
            //        new Pushpin() { 
            //            Location = new System.Device.Location.GeoCoordinate(station.Wgs84Latitude, station.Wgs84Longitude, station.Altitude),
            //            DataContext = station,
            //            ContentTemplate = this.Resources["PushPinDataTemplate"] as DataTemplate,
            //            IsHitTestVisible = true,
            //            IsTabStop = true
                        
            //        });
            //}
        }

        private void PushPin_Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CurrentStationInfo = ((sender as Button).Tag as IStationInfo);
            NavigationService.Navigate(new Uri("/View/StationInfoView.xaml", UriKind.Relative));
        }

        
    }
}
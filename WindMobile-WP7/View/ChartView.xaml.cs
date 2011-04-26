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

namespace Ch.Epix.WindMobile.WP7.View
{
    public partial class ChartView : PhoneApplicationPage
    {
        public ViewModel.StationInfoViewModel ViewModel
        {
            get
            {
                return this.DataContext as ViewModel.StationInfoViewModel;
            }
        }

        public ChartView()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            ViewModel.GetStationChartCommand.Execute(3600);
        }
    }
}
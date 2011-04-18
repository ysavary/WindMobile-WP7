﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight;

namespace Ch.Epix.WindMobile.WP7.ViewModel
{
    public class ExceptionViewModel : ViewModelBase
    {
        public Exception Exception { get; private set; }

        public string ApplicationName
        {
            get
            {
                return "WIND MOBILE";
            }
        }

        public string PageName
        {
            get
            {
                return "exception";
            }
        }

        public ExceptionViewModel(Exception ex)
        {
            Exception = ex;
        }
    }
}

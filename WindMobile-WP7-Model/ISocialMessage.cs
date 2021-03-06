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

namespace Ch.Epyx.WindMobile.WP7.Model
{
    public interface ISocialMessage
    {
        DateTime Date { get; }
        string Pseudo { get; }
        string Text { get; }
    }
}

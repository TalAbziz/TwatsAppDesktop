﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TwatsAppClient.Helpers
{
    /// <summary>
    /// nice thing to have when wokring, takes a grid and makes it visible;
    /// </summary>
    public static class SpinnerExtensions
    {
        public static void Work(this Grid grid)
        {
            grid.Visibility = System.Windows.Visibility.Visible;
        }
        public static void Stop(this Grid grid)
        {
            grid.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}

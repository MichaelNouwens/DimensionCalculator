﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DimensionCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    //====================================================\\
    //SIMPLE INTEREST NAVIGATION PAGE
    //====================================================\\
    public sealed partial class SimInterest : Page
    {
        public SimInterest()
        {
            this.InitializeComponent();
        }
        //====================================================\\
        //==================(navigation buttons)==================\\
        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SimpleInterest_A)); //To calculate A page
        }

        private void btnP_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SimpleInterest_P)); //To calculate P page
        }

        private void btnR_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SimpleInterest_R)); //To calculate R page
        }

        private void btnTP_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SimpleInterest_TP)); //To calculate N page
        }

        private void btnBackSI_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage)); //Back to main page
        }
        //====================================================\\
        
    }
}

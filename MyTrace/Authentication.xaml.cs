﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTrace
{
    /// <summary>
    /// Interaction logic for Authentication.xaml
    /// </summary>
    public partial class Authentication : Page
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

      
        public void start()
        {
            int value = 1;
            Console.WriteLine(value);
        }
        public void stop()
        {
            int value = 0;
            Console.WriteLine(value);
        }

       

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            start();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            stop();
        }
    }
}

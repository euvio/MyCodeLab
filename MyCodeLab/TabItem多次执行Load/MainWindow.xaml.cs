﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TabItem多次执行Load
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabItem1_OnLoaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TabItem1 Load...");
        }

        private void TabItem1_OnUnloaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TabItem1 unLoad...");
        }

        private void TabItem1_OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Console.WriteLine(($"TabItem1 {e.Property.Name}-{e.OldValue}-{e.NewValue}..."));
        }
    }
}

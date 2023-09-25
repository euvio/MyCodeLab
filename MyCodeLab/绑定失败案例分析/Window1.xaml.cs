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
using System.Windows.Shapes;

namespace 绑定失败案例分析
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ListBox.DataContext = new string[] { "1", "2", "3" };
            ListBox.ItemsSource = new string[] { "1", "2", "3" };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.Write(TreeHelper.getTree(this));
        }
    }
}

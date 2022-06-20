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

namespace DataBinding
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

        private void HelloBoundWorldSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new HelloBoundWorldSample().ShowDialog();
        }

        private void DataContextSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new DataContextSample().ShowDialog();
        }
    }
}

﻿using System.Windows;

namespace Common_interface_controls
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

        private void MenuSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new MenuSample().ShowDialog();
        }

        private void MenuIconCheckableSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new MenuIconCheckableSample().ShowDialog();
        }

        private void MenuWithCommandsSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new MenuWithCommandsSample().ShowDialog();
        }

        private void ContextMenuSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ContextMenuSample().ShowDialog();
        }

        private void ContextMenuWithCommandsSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ContextMenuWithCommandsSample().ShowDialog();
        }

        private void ContextMenuManuallyInvokedSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ContextMenuManuallyInvokedSample().ShowDialog();
        }

        private void ToolbarSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ToolbarSample().ShowDialog();
        }

        private void ToolbarIconSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ToolbarIconSample().ShowDialog();
        }

        private void ToolbarPositionSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ToolbarPositionSample().ShowDialog();
        }

        private void ToolbarCustomControlsSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ToolbarCustomControlsSample().ShowDialog();
        }

        private void StatusBarSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new StatusBarSample().ShowDialog();
        }

        private void StatusBarAdvancedSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new StatusBarAdvancedSample().ShowDialog();
        }
    }
}

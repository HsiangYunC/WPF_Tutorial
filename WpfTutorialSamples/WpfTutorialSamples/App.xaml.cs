﻿using System.Globalization;
using System.Threading;
using System.Windows;

namespace WpfTutorialSamples
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
		// manually create starting window
		private void Application_Startup(object sender, StartupEventArgs e)
		{
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            // Create the startup window
            MainWindow wnd = new MainWindow();
            wnd.Show();
        }
    }
}

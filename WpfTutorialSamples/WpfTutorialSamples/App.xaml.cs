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
			// Create the startup window
			MainWindow wnd = new MainWindow();

            // From the Project menu select "[Project name] properties"
            // and then go to the Debug tab, where you can define a command-line parameter.
            // c:\Windows\win.ini
            if (e.Args.Length == 1)
            {
                MessageBox.Show("Now opening file: \n\n" + e.Args[0]);
            }

            wnd.Show();
		}
	}
}

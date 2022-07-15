using System.Windows;

namespace Dialogs
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

        private void MessageBoxSample_Click(object sender, RoutedEventArgs e)
        {
            new MessageBoxSample().ShowDialog();
        }
    }
}

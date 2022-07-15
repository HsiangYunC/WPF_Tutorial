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

        private void OpenFileDialogSample_Click(object sender, RoutedEventArgs e)
        {
            new OpenFileDialogSample().ShowDialog();
        }

        private void OpenFileDialogMultipleFilesSample_Click(object sender, RoutedEventArgs e)
        {
            new OpenFileDialogMultipleFilesSample().ShowDialog();
        }
    }
}

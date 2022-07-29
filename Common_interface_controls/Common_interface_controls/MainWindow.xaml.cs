using System.Windows;

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
    }
}

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
    }
}

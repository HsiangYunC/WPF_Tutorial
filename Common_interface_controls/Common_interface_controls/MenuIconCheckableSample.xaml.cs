using System.Windows;

namespace Common_interface_controls
{
    /// <summary>
    /// MenuIconCheckableSample.xaml 的互動邏輯
    /// </summary>
    public partial class MenuIconCheckableSample : Window
    {
        public MenuIconCheckableSample()
        {
            InitializeComponent();
        }

        private void MenuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("new");
        }
    }
}

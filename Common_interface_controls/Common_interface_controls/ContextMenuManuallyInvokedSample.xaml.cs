using System.Windows;
using System.Windows.Controls;

namespace Common_interface_controls
{
    /// <summary>
    /// ContextMenuSample.xaml 的互動邏輯
    /// </summary>
    public partial class ContextMenuManuallyInvokedSample : Window
    {
        public ContextMenuManuallyInvokedSample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContextMenu cm = this.FindResource("cmButton") as ContextMenu;
            cm.PlacementTarget = sender as Button;
            cm.IsOpen = true;
        }
    }
}

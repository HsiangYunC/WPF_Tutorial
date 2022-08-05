using System.Windows;
using System.Windows.Input;

namespace Common_interface_controls
{
    /// <summary>
    /// ToolbarSample.xaml 的互動邏輯
    /// </summary>
    public partial class ToolbarSample : Window
    {
        public ToolbarSample()
        {
            InitializeComponent();
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}

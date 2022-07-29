using System.Windows;
using System.Windows.Input;

namespace Common_interface_controls
{
    /// <summary>
    /// MenuWithCommandsSample.xaml 的互動邏輯
    /// </summary>
    public partial class MenuWithCommandsSample : Window
    {
        public MenuWithCommandsSample()
        {
            InitializeComponent();
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            txtEditor.Text = "";
        }
    }
}

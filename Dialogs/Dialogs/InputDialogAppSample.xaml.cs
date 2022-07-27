using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// InputDialogAppSample.xaml 的互動邏輯
    /// </summary>
    public partial class InputDialogAppSample : Window
    {
        public InputDialogAppSample()
        {
            InitializeComponent();
        }

        private void btnEnterName_Click(object sender, RoutedEventArgs e)
        {
            InputDialogSample inputDialogSample = new InputDialogSample("Please enter your name:", "John Doe");
            if (inputDialogSample.ShowDialog() == true)
            {
                lbName.Text = inputDialogSample.Answer;
            }
        }
    }
}

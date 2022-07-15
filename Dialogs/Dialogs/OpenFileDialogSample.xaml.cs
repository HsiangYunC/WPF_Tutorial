using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// OpenFileDialogSample.xaml 的互動邏輯
    /// </summary>
    public partial class OpenFileDialogSample : Window
    {
        public OpenFileDialogSample()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
    }
}

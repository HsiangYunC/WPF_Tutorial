using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// OpenFileDialogMultipleFilesSample.xaml 的互動邏輯
    /// </summary>
    public partial class OpenFileDialogMultipleFilesSample : Window
    {
        public OpenFileDialogMultipleFilesSample()
        {
            InitializeComponent();
        }

        private void btnOpenFiles_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // [Filter] :
            // a combo box for selecting the file types
            // Text files (*.txt)|*.txt
            // All files (*.*)|*.*
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // image files could be specified as both JPEG and PNG files
            // openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";

            // [Initial directory] :
            // openFileDialog.InitialDirectory = @"C:\temp\";

            // If you want to use one of the special folders on Windows
            // e.g. the Desktop, My Documents or the Program Files directory
            // Environment class and its members for dealing with special folders
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // [Multiple files] :
            // want to use the OpenFileDialog to select more than one file at a time
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    lbFiles.Items.Add(Path.GetFileName(filename));
                }
            }
        }
    }
}

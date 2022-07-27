using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// SaveFileDialogSample.xaml 的互動邏輯
    /// </summary>
    public partial class SaveFileDialogSample : Window
    {
        public SaveFileDialogSample()
        {
            InitializeComponent();
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs",
                //InitialDirectory = @"c:\temp",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
            }
        }
    }
}

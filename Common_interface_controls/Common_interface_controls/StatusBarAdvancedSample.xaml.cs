using System.Windows;

namespace Common_interface_controls
{
    /// <summary>
    /// StatusBarAdvancedSample.xaml 的互動邏輯
    /// </summary>
    public partial class StatusBarAdvancedSample : Window
    {
        public StatusBarAdvancedSample()
        {
            InitializeComponent();
        }

        private void txtEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txtEditor.GetLineIndexFromCharacterIndex(txtEditor.CaretIndex);
            int col = txtEditor.CaretIndex - txtEditor.GetCharacterIndexFromLineIndex(row);
            lbCursorPosition.Text = "Line " + (row + 1) + ", Char " + (col + 1);
        }
    }
}

using System.Windows;

namespace RichTextControls
{
    /// <summary>
    /// FlowDocumentSearchSample.xaml 的互動邏輯
    /// </summary>
    public partial class FlowDocumentSearchSample : Window
    {
        public FlowDocumentSearchSample()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // support the Ctrl+F keyboard shortcut for initiating a search
            fdViewer.Find();
        }
    }
}

using System.Windows;

namespace RichTextControls
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FlowDocumentScrollViewerSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new FlowDocumentScrollViewerSample().ShowDialog();
        }

        private void FlowDocumentScrollViewerZoomSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new FlowDocumentScrollViewerZoomSample().ShowDialog();
        }
    }
}

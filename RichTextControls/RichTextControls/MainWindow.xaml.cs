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

        private void FlowDocumentTextAlignmentSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new FlowDocumentTextAlignmentSample().ShowDialog();
        }

        private void FlowDocumentPageViewerSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new FlowDocumentPageViewerSample().ShowDialog();
        }

        private void FlowDocumentSearchSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new FlowDocumentSearchSample().ShowDialog();
        }

        private void FlowDocumentReaderSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new FlowDocumentReaderSample().ShowDialog();
        }

        private void CodeBehindFlowDocumentSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new CodeBehindFlowDocumentSample().ShowDialog();
        }

        private void ExtendedFlowDocumentSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ExtendedFlowDocumentSample().ShowDialog();
        }

        private void BlockUIContainerSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new BlockUIContainerSample().ShowDialog();
        }

        private void RichTextBoxSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new RichTextBoxSample().ShowDialog();
        }

        private void RichTextBoxTextSelectionSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new RichTextBoxTextSelectionSample().ShowDialog();
        }

        private void RichTextBoxParagraphSpacingSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new RichTextBoxParagraphSpacingSample().ShowDialog();
        }
    }
}

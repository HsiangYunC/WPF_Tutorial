using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace RichTextControls
{
    /// <summary>
    /// CodeBehindFlowDocumentSample.xaml 的互動邏輯
    /// </summary>
    public partial class CodeBehindFlowDocumentSample : Window
    {
        public CodeBehindFlowDocumentSample()
        {
            InitializeComponent();

            FlowDocument doc = new FlowDocument();

            Paragraph p = new Paragraph(new Run("Hello, world!"));
            p.FontSize = 36;
            doc.Blocks.Add(p);

            p = new Paragraph(new Run("The ultimate programing greeting!"));
            p.FontSize = 14;
            p.FontStyle = FontStyles.Italic;
            p.TextAlignment = TextAlignment.Left;
            p.Foreground = Brushes.Gray;
            doc.Blocks.Add(p);

            fdViewer.Document = doc;
        }
    }
}

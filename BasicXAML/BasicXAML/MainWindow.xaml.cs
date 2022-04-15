using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BasicXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.FontWeight = FontWeights.Bold;
            btn.VerticalAlignment = VerticalAlignment.Top;
            btn.Margin = new Thickness(0, 150, 0, 0);

            WrapPanel pnl = new WrapPanel();

            TextBlock txt = new TextBlock();
            txt.Text = "*Multi*";
            txt.Foreground = Brushes.Blue;
            pnl.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "*Color*";
            txt.Foreground = Brushes.Red;
            pnl.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "*Button*";
            pnl.Children.Add(txt);

            btn.Content = pnl;
            Grid.Children.Add(btn);
        }
    }
}

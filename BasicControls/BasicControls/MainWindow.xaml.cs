using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBlockSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new TextBlockSample().ShowDialog();
        }

        private void TextBlockInlineFormattingSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new TextBlockInlineFormattingSample().ShowDialog();
        }

        private void LabelControlSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new LabelControlSample().ShowDialog();
        }

        private void TextBoxControlSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new TextBoxControlSample().ShowDialog();
        }

        private void ButtonControlSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ButtonControlSample().ShowDialog();
        }

        private void CheckBoxControlSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new CheckBoxControlSample().ShowDialog();
        }
    }
}

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

namespace Control_concepts
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

        private void ToolTipsSimpleSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ToolTipsSimpleSample().ShowDialog();
        }

        private void ToolTipsAdvancedSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new ToolTipsAdvancedSample().ShowDialog();
        }
    }
}

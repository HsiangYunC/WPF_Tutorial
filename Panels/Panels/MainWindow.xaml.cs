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

namespace Panels
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

        private void CanvasSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new CanvasSample().ShowDialog();
        }

        private void CanvasZIndexSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new CanvasZIndexSample().ShowDialog();
        }

        private void WrapPanelSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new WrapPanelSample().ShowDialog();
        }

        private void StackPanelSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new StackPanelSample().ShowDialog();
        }

        private void DockPanelSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new DockPanelSample().ShowDialog();
        }

        private void GridSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new GridSample().ShowDialog();
        }

        private void TabularGridSampleButton_Click(object sender, RoutedEventArgs e)
        {
            new TabularGridSample().ShowDialog();
        }
    }
}

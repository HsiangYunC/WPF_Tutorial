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
using System.Windows.Shapes;

namespace BasicControls
{
    /// <summary>
    /// Interaction logic for CheckBoxControlSample.xaml
    /// </summary>
    public partial class CheckBoxControlSample : Window
    {
        public CheckBoxControlSample()
        {
            InitializeComponent();
        }

        private void cb_CheckChanged(object sender, RoutedEventArgs e)
        {
            cbAll.IsChecked = null;
            if ((cbABC.IsChecked == true) && (cbabc.IsChecked == true) && (cb123.IsChecked == true))
            {
                cbAll.IsChecked = true;
            }
            if ((cbABC.IsChecked == false) && (cbabc.IsChecked == false) && (cb123.IsChecked == false))
            {
                cbAll.IsChecked = false;
            }
        }

        private void cbAll_CheckChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = cbAll.IsChecked == true;
            cbABC.IsChecked = newVal;
            cbabc.IsChecked = newVal;
            cb123.IsChecked = newVal;
        }
    }
}

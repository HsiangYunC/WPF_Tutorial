using Microsoft.Win32;
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
    /// Interaction logic for ImageControlSample.xaml
    /// </summary>
    public partial class ImageControlSample : Window
    {
        public ImageControlSample()
        {
            InitializeComponent();
        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imageFromFile.Source = new BitmapImage(fileUri);
            }
        }

        private void btnLoadFromResource_Click(object sender, RoutedEventArgs e)
        {
            Uri resourceUri = new Uri("/images/Google_Fit_icon_(2018).svg.png", UriKind.Relative);
            imageFromResource.Source = new BitmapImage(resourceUri);
        }
    }
}

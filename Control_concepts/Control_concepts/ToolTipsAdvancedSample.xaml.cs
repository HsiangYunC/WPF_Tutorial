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

namespace Control_concepts
{
    /// <summary>
    /// Interaction logic for ToolTipsAdvancedSample.xaml
    /// </summary>
    public partial class ToolTipsAdvancedSample : Window
    {
        public ToolTipsAdvancedSample()
        {
            InitializeComponent();
        }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            if (e.Uri.IsAbsoluteUri)
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = e.Uri.AbsoluteUri,
                    // UseShellExecute property is set to false in .NET Core by default,
                    // to open https:// link you have to set it to true,
                    // because it isn't an executable file.
                    UseShellExecute = true
                };

                System.Diagnostics.Process.Start(psi);
            }
        }
    }
}

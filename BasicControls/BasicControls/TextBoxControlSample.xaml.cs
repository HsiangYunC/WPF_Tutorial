using System;
using System.Windows;
using System.Windows.Controls;

namespace BasicControls
{
    /// <summary>
    /// Interaction logic for TextBoxControlSample.xaml
    /// </summary>
    public partial class TextBoxControlSample : Window
    {
        public TextBoxControlSample()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }
    }
}

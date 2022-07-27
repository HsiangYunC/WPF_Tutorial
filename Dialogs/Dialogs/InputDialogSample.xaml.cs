using System;
using System.Windows;

namespace Dialogs
{
    /// <summary>
    /// InputDialogSample.xaml 的互動邏輯
    /// </summary>
    public partial class InputDialogSample : Window
    {
        public InputDialogSample(string question, string defaultAnswer = "")
        {
            InitializeComponent();
            lbQuestion.Content = question;
            txtAnswer.Text = defaultAnswer;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            txtAnswer.SelectAll();
            txtAnswer.Focus();
        }

        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string Answer => txtAnswer.Text;
    }
}

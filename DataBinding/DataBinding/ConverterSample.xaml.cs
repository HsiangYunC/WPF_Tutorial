using System;
using System.Windows;
using System.Windows.Data;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for ConverterSample.xaml
    /// </summary>
    public partial class ConverterSample : Window
    {
        public ConverterSample()
        {
            InitializeComponent();
        }
    }
    public class YesNoToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "yes":
                case "oui": // French words
                    return true;
                case "no":
                case "non": // French words
                    return false;
            }
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is bool)
            {
                if ((bool)value == true)
                {
                    return "yes";
                }
                else
                {
                    return "no";
                }
            }
            return "no";
        }
    }
}

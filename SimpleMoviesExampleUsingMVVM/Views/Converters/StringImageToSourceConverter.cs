using System;
using System.Windows.Data;

namespace SimpleMoviesExampleUsingMVVM.Views.Converters
{
    [ValueConversion(typeof(string), typeof(string))]
    public class StringImageToSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var source = (string)value;

            if (string.IsNullOrEmpty(source))
                return source;

            value = "/SimpleMoviesExampleUsingMVVM;component/" + value;

            return value;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

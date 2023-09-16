using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Common.converter
{
    public class StrLengthConverter:IValueConverter
    {
        public object Convert(
        object value,
        Type targetType,
        object parameter,
        System.Globalization.CultureInfo culture)
        {
            if (value is null)
                return 0;

            return value.ToString().Length;
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}

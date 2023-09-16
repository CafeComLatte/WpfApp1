using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Common.converter
{
    public class EnumToBooleanConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            System.Globalization.CultureInfo culture)
        {
            string strEnum = value.ToString();

            if (parameter != null && parameter.ToString().Equals(strEnum))
            {
                return true;
            }
            else
            {
                return false;
            }
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

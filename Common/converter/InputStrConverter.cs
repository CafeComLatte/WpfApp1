using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Common.converter
{
    public class InputStrConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string str = value.ToString();
            string formatedStr = str.Substring(0, 4) + "/" + str.Substring(4,2) + "/" + str.Substring(6,2);
            Console.WriteLine(formatedStr); 
            return formatedStr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

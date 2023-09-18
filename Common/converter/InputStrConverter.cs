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

            if (null == str && "".Equals(str))
                return null;

            if(str.Length == 8)
            {
                return ConvertDate(str);
            }else if(str.Length == 4)
            {
                return ConvertTime(str);
            }

            return null;
            
        }

        private string ConvertTime(string str)
        {
            return str.Substring(0, 2) + ":" + str.Substring(2, 2);
        }

        private string ConvertDate(string str)
        {
            return str.Substring(0, 4) + "/" + str.Substring(4, 2) + "/" + str.Substring(6, 2);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}

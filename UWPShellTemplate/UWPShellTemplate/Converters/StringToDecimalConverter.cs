using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPShellTemplate.Converters {
    public class StringToDecimalConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (value == null)
                return null;

            if (parameter == null)
                return value;

            // this does rounding to 2 decimals when ConverterParameter='{}{0:N2}'
            /*
            Decimal decValue;
            string formatted = (string)value;
            if (decimal.TryParse((string)value, out decValue)) {
                decValue = decimal.Parse((string)value);
                formatted = string.Format((string)parameter, decValue);  
            }
            */

            // this does truncating to 2 decimals with no rounding
            Decimal decValue;
            string formatted = (string)value;
            if (decimal.TryParse((string)value, out decValue)) {
                string s = (string)value;
                int pos = s.IndexOf('.');
                formatted = s.Substring(0, pos) + s.Substring(pos, 3);
            }

            return formatted;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            if (value == null)
                return null;

            return value.ToString();
        }
    }
}

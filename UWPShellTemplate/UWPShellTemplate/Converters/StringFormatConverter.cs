using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPShellTemplate.Converters {

    // https://marcominerva.wordpress.com/2013/04/26/stringformat-converter-for-windows-store-apps/
    public class StringFormatConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (value == null)
                return null;

            if (parameter == null)
                return value;

            return string.Format((string)parameter, value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}

/*
<TextBlock Text = "{Binding Name, 
    Converter={StaticResource StringFormatConverter}, 
    ConverterParameter='Welcome, {0}!'}" />
 
<TextBlock Text = "{Binding Amount, 
    Converter={StaticResource StringFormatConverter}, 
    ConverterParameter='{}{0:C}'}" />
*/

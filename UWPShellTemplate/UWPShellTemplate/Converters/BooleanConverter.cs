using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPShellTemplate.Converters {
    public class BooleanConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return value.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            return Boolean.Parse(value as string);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPSimpleTemplate.Converters {
    public class BooleanNegationConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            Boolean b = (Boolean)value;
            return !b;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace UWPSimpleTemplate.Converters {
    public class DecimalToStringConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            return value.ToString();
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            decimal retValue;
            if (decimal.TryParse(value as string, out retValue)) {
                return retValue;
            }
            return 0.0M;
        }
    }


    //// http://stackoverflow.com/questions/18964518/wpf-converters-with-different-decimal-number
    //public class DecimalToStringConverter : IValueConverter {
    //    public object Convert(object value, Type targetType, object parameter, string language) {
    //        return value == null ? null : ((double)value).ToString("#,0.##########");
    //    }

    //    public object ConvertBack(object value, Type targetType, object parameter, string language) {
    //        double retValue;
    //        if (double.TryParse(value as string, out retValue)) {
    //            return retValue;
    //        }
    //        return DependencyProperty.UnsetValue;
    //    }
    //}
}

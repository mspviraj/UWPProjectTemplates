using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace UWPShellTemplate.Utils {
    public class XamlUtils {
        public static childItem FindVisualChild<childItem>(DependencyObject obj) where childItem : DependencyObject {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++) {
                DependencyObject child = VisualTreeHelper.GetChild(obj, i);
                if (child != null && child is childItem) {
                    return (childItem)child;
                }
                else {
                    childItem childOfChild = FindVisualChild<childItem>(child);
                    if (childOfChild != null) {
                        return childOfChild;
                    }
                }
            }
            return null;
        }
    }
}

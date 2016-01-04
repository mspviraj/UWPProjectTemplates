using Prism.Windows.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace PrismShellTemplate.Behaviors {

    // Documentation on validating user input is at http://go.microsoft.com/fwlink/?LinkID=288817&clcid=0x409
    public class HighlightFormFieldOnErrors : BehaviorBase<FrameworkElement> {
        public static readonly DependencyProperty PropertyErrorsProperty =
            DependencyProperty.RegisterAttached("PropertyErrors", typeof(object), typeof(HighlightFormFieldOnErrors), new PropertyMetadata(BindableValidator.EmptyErrorsCollection, OnPropertyErrorsChanged));

        // The default for this property only applies to TextBox controls.
        public static readonly DependencyProperty HighlightStyleNameProperty =
            DependencyProperty.RegisterAttached("HighlightStyleName", typeof(string), typeof(HighlightFormFieldOnErrors), new PropertyMetadata("HighlightTextBoxStyle"));

        // The default for this property only applies to TextBox controls.
        protected static readonly DependencyProperty OriginalStyleNameProperty =
            DependencyProperty.RegisterAttached("OriginalStyleName", typeof(Style), typeof(HighlightFormFieldOnErrors), new PropertyMetadata("BaseTextBoxStyle"));

        public object PropertyErrors {
            get { return (object)GetValue(PropertyErrorsProperty); }
            set { SetValue(PropertyErrorsProperty, value); }
        }

        public string HighlightStyleName {
            get { return (string)GetValue(HighlightStyleNameProperty); }
            set { SetValue(HighlightStyleNameProperty, value); }
        }

        public string OriginalStyleName {
            get { return (string)GetValue(OriginalStyleNameProperty); }
            set { SetValue(OriginalStyleNameProperty, value); }
        }

        protected override void OnAttached() {
        }

        protected override void OnDetached() {
        }

        private static void OnPropertyErrorsChanged(DependencyObject d, DependencyPropertyChangedEventArgs args) {
            if (args == null || args.NewValue == null) {
                return;
            }

            var control = ((BehaviorBase<FrameworkElement>)d).AssociatedObject;
            var propertyErrors = (ICollection<string>)args.NewValue;

            Style style = propertyErrors.Any() ?
                (Style)Application.Current.Resources[((HighlightFormFieldOnErrors)d).HighlightStyleName] :
                (Style)Application.Current.Resources[((HighlightFormFieldOnErrors)d).OriginalStyleName];

            control.Style = style;
        }
    }
}

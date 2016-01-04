using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismSimpleTemplate.ViewModels {
    public class MainPageViewModel : ViewModelBase {
        private string appName;

        public MainPageViewModel() {
            AppName = "PrismSimpleTemplate";
        }

        public string AppName {
            get { return appName; }
            set {
                SetProperty<string>(ref appName, value);
            }
        }
    }
}

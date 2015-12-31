using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSimpleTemplate.ViewModels {
    public class MainPageViewModel : BindableBase {
        private string appName;
        public string AppName {
            get { return appName; }
            set {
                SetProperty<string>(ref appName, value);
            }
        }
    }
}

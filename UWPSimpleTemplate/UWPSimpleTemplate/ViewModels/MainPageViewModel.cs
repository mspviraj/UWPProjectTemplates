using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPSimpleTemplate.Commands;

namespace UWPSimpleTemplate.ViewModels {
    public class MainPageViewModel : BindableBase {
        private string appName;
        private string saveAppName;
        public DelegateCommand ClickMeCommand { get; set; }

        public MainPageViewModel() {
            saveAppName = App.Current.Resources["AppName"].ToString();
            ClickMeCommand = new DelegateCommand(ExecuteClickMeCommand, CanExecuteClickMeCommand);
        }

        public string AppName {
            get { return appName; }
            set {
                SetProperty<string>(ref appName, value);
            }
        }

        private void ExecuteClickMeCommand(object args) {
            AppName = AppName == saveAppName ? "Hello UWP!" : saveAppName;
        }

        private bool CanExecuteClickMeCommand(object args) {
            return true;
        }
    }
}

using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Windows.Navigation;
using Prism.Commands;

namespace PrismShellTemplate.ViewModels {
    public class BasicPageViewModel : ViewModelBase {
        private INavigationService navigationService;
        public DelegateCommand GoToCommandBarPage { get; set; }

        public BasicPageViewModel(INavigationService navigationService) {
            this.navigationService = navigationService;
            GoToCommandBarPage = new DelegateCommand(ExecuteGoToCommandBarPage, CanExecuteGoToCommandBarPage);
        }

        public void ExecuteGoToCommandBarPage() {
            navigationService.Navigate("CommandBar", null);
        }

        public bool CanExecuteGoToCommandBarPage() {
            return true;
        }

        public override void OnNavigatingFrom(NavigatingFromEventArgs e, Dictionary<string, object> viewModelState, bool suspending) {
            base.OnNavigatingFrom(e, viewModelState, suspending);
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState) {
            base.OnNavigatedTo(e, viewModelState);
        }
    }
}

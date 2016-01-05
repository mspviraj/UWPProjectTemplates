using Prism.Unity.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using Prism.Windows.AppModel;
using Windows.ApplicationModel.Resources;
using PrismShellTemplate.Views;
using Windows.UI.Core;

namespace PrismShellTemplate {
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : PrismUnityApplication {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App() {
            this.InitializeComponent();

        }

        // rjl: Acknowledgement
        // CreateShell method from PrismLibrary/Prism-Samples-Windows/SplitViewSample at
        // https://github.com/PrismLibrary/Prism-Samples-Windows
        // CreateShell replaces AppShell's original Frame with the NavigationService's Frame.
        // In effect all navigation is now using Prism's NavigationService.
        // Any ViewModel can use Prism's NavigationService via Prism.Unity DependencyInjection as
        // done in BasicPageViewModel.
        protected override UIElement CreateShell(Frame rootFrame) {
            var shell = Container.Resolve(typeof(AppShell), "AppShell") as AppShell;
            shell.SetContentFrame(rootFrame);
            return shell;
        }

        // rjl: Now using Prism NavigationService for navigation rather than the original code 
        // which used AppShell's Frame for navigation.
        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args) {
            NavigationService.Navigate("Landing", null);
            return Task.FromResult(true);
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e) {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        // rjl: Hiding SystemNavigationManager's BackButton Icon
        protected override void OnNavigated(object sender, NavigationEventArgs e) {
            base.OnNavigated(sender, e);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        // ==========================================================================
        // TODO: Test if Prism calls this method on suspension.
        //       May need to override OnSuspendingApplicationAsync()
        // ==========================================================================
        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e) {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }

        protected override void ConfigureContainer() {
            base.ConfigureContainer();
            //RegisterTypeIfMissing(typeof(IFakeService), typeof(FakeService), true);
        }
    }
}

using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using VimarCrm.Pages;
using VimarCrm.Resources;
using VimarCrm.Views;

namespace VimarCrm.Services
{
    public class NavigationService : INavigationService
    {

        public void CloseLoadingView()
        {

        }

        public  Task DisplayAlertAsync(string title, string message, string cancel)
        {
            //MainThread.BeginInvokeOnMainThread( () =>
            // Shell.Current.DisplayAlert(title, message, cancel));

            return Shell.Current.DisplayAlert(title, message, cancel);

        }

        public void DisplayLoadingView()
        {
          
        }


        public  Task GoToAsync(ShellNavigationState state, IDictionary<string, object> parameters = null)
        {
            return Shell.Current.GoToAsync(state, parameters);
        }

        public  Task GoToAsync(ShellNavigationState state)
        {
            return Shell.Current.GoToAsync(state);
        }

        public  Task DisplaySnackbarAsync(string text)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            var snackbarOptions = new SnackbarOptions
            {
                BackgroundColor = Colors.Green,
                TextColor = Colors.White,
                ActionButtonTextColor = Colors.Yellow,
                CornerRadius = new CornerRadius(10),
                Font = Microsoft.Maui.Font.SystemFontOfSize(20),
                ActionButtonFont = Microsoft.Maui.Font.SystemFontOfSize(12)
            };

            string actionButtonText = AppResource.PremiPerChiudere;
            //Action action = async () => await DisplayAlert("Snackbar ActionButton Tapped", "The user has tapped the Snackbar ActionButton", "OK");
            TimeSpan duration = TimeSpan.FromSeconds(3);

            var snackbar = Snackbar.Make(text, /*action*/ null, actionButtonText, duration, snackbarOptions);

            return snackbar.Show(cancellationTokenSource.Token);
        }

        public Task LogoutAsync()
        {
            return Shell.Current.GoToAsync("//" + nameof(LoginPage));
            //Application.Current.MainPage = new AppShell();
        }

        public  Task<bool> DisplayAlertAsync(string title, string message, string accept, string cancel)
        {
            return  Shell.Current.DisplayAlert(title, message, accept, cancel);
        }
    }
}

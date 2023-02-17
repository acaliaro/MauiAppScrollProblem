using CommunityToolkit.Maui.Views;

namespace VimarCrm.Services
{
    public interface INavigationService
    {
        Task DisplayAlertAsync(string title, string message, string cancel);
        Task<bool> DisplayAlertAsync(string title, string message, string accept, string cancel);

        Task GoToAsync(ShellNavigationState state);

        Task GoToAsync(ShellNavigationState state, IDictionary<string, object> parameters);
        void DisplayLoadingView();
        void CloseLoadingView();
        Task DisplaySnackbarAsync(string text)  ;
        Task LogoutAsync();
    }
}

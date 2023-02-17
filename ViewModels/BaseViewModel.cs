using CommunityToolkit.Mvvm.ComponentModel;
using VimarCrm.Services;

namespace VimarCrm.ViewModels
{

    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBusy;
        internal INavigationService navigationService;

        public BaseViewModel( INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        partial void OnIsBusyChanged(bool value)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                try
                {

                    if (value)
                        this.navigationService.DisplayLoadingView();
                    else
                        this.navigationService.CloseLoadingView();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });

        }

    }

}
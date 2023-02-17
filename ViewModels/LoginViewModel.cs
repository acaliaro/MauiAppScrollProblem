using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using VimarCrm.Pages;
using VimarCrm.Resources;
using VimarCrm.Services;

namespace VimarCrm.ViewModels
{

    public class SocialMedia
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public partial class LoginViewModel : BaseViewModel
    {

        [ObservableProperty]
        //[NotifyDataErrorInfo]
        //[Required]
        //[MinLength(1)] // Any other validation attributes too...
        string utente;

        [ObservableProperty]
        //[NotifyDataErrorInfo]
        //[Required]
        //[MinLength(1)] // Any other validation attributes too...
        string password;

        public bool IsAccediEnabled { get { return string.IsNullOrEmpty(Utente) == false && string.IsNullOrEmpty(Password) == false; } }

        public LoginViewModel( INavigationService navigationService) : base( navigationService)
        {

        }

        [RelayCommand]
        async Task ImpostazioniAsync()
        {
            try
            {

            }
            catch (Exception ex)
            {
                await navigationService.DisplayAlertAsync(AppResource.Attenzione, ex.Message, AppResource.Ok);
            }
            finally { IsBusy = false; }
        }

        [RelayCommand]
        async Task AccediAsync()
        {
            try
            {

                IsBusy = true;

                    //await Shell.Current.GoToAsync("//" + nameof(MenuClientiPage));
            }
            catch (Exception ex)
            {
                await navigationService.DisplayAlertAsync(AppResource.Attenzione, ex.Message, AppResource.Ok);
            }
            finally { IsBusy = false; }
        }

    }
}

using VimarCrm.ViewModels;

namespace VimarCrm.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel loginViewModel)
    {
        InitializeComponent();
        BindingContext = loginViewModel;
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(e.NewTextValue != null)
            System.Diagnostics.Debug.WriteLine(e.NewTextValue);
    }
}
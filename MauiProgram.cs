using VimarCrm.Pages;
using VimarCrm.Services;
using VimarCrm.ViewModels;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using LocalizationResourceManager.Maui;
using VimarCrm.Resources;

namespace VimarCrm;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseLocalizationResourceManager(settings =>
            {
                settings.AddResource(AppResource.ResourceManager);
                settings.RestoreLatestCulture(true);
            })
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("FontAwesomeSolid900.otf", "FontAwesome");
                fonts.AddFont("fa-solid-900.ttf", "FASolid900");

            });

        // Pages e ViewModels
        // Nella shell metto solo le route che servono per la navigazione dalla shell (in questo caso la login e poi la home che diventa la root della navigation stack).
        // Le altre route le registro di seguito utilizzando AddTransientWithShellRoute
        builder.Services.AddTransient<LoginPage, LoginViewModel>();
        //builder.Services.AddTransient<MenuClientiPage, MenuClientiViewModel>();


        // Services
        builder.Services.AddSingleton<INavigationService, NavigationService>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

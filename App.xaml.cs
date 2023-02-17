using CommunityToolkit.Mvvm.Messaging;

namespace VimarCrm;

public partial class App : Application
{

    public App()
	{


        InitializeComponent();

		MainPage = new AppShell();

	}

    //protected override Window CreateWindow(IActivationState activationState)
    //{
    //    Window window = base.CreateWindow(activationState);

    //    window.Created += (s, e) =>
    //    {
    //        // Custom logic
    //    };

    //    window.Activated += (s, e) =>
    //    {
    //        System.Diagnostics.Debug.WriteLine("Activated", "CreateWindow");
    //        try
    //        {
    //            WeakReferenceMessenger.Default.Register(this);
    //        }
    //        catch(Exception ex) {
    //            System.Diagnostics.Debug.WriteLine(ex.Message, "CreateWindow");
    //        }
    //    };

    //    window.Deactivated += (s, e) =>
    //    {
    //        System.Diagnostics.Debug.WriteLine("Deactivated", "CreateWindow");
    //        WeakReferenceMessenger.Default.Unregister<TokenExpiredMessage>(this);
    //    };

    //    return window;
    //}

}

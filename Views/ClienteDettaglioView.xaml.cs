using VimarCrm.Models.Cliente;

namespace VimarCrm.Views;

public partial class ClienteDettaglioView : ContentView
{
    public static readonly BindableProperty CustomerProperty = BindableProperty.Create(nameof(Customer), typeof(ClienteItem), typeof(ClienteDettaglioView));

    public ClienteItem Customer
    {
        get => GetValue(CustomerProperty) as ClienteItem;
        set => SetValue(CustomerProperty, value);
    }

    public ClienteDettaglioView()
	{
		InitializeComponent();
	}
}
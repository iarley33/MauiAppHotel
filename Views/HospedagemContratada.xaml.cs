namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        // Navega��o para a p�gina "Sobre"
        await Navigation.PushAsync(new Sobre());
    }
}
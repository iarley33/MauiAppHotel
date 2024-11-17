namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada()
    {
        InitializeComponent();
    }

    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        // Navegação para a página "Sobre"
        await Navigation.PushAsync(new Sobre());
    }
}
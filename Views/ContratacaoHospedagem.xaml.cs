namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // Método chamado quando o botão "Avançar" é clicado
    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        // Navega para a página "Sobre"
        await Navigation.PushAsync(new Sobre());
    }
}

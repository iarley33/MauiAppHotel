namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // M�todo chamado quando o bot�o "Avan�ar" � clicado
    private async void OnAvancarClicked(object sender, EventArgs e)
    {
        // Navega para a p�gina "Sobre"
        await Navigation.PushAsync(new Sobre());
    }
}

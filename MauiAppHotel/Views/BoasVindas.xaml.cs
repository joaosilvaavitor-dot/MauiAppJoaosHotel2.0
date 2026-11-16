namespace MauiAppHotel.Views;

public partial class BoasVindas : ContentPage
{
    public BoasVindas()
    {
        InitializeComponent();
    }

    private async void Reserva_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContratacaoHospedagem());
    }

    private async void Promocoes_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Promocoes());
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}

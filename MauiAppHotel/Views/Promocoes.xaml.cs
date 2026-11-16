using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class Promocoes : ContentPage
{
    public Promocoes()
    {
        InitializeComponent();

        lista_promocoes.ItemsSource = new List<Promocao>
        {
            new Promocao
            {
                Emoji = "👨‍👩‍👧",
                Titulo = "Pacote Família",
                Descricao = "Crianças pagam metade da diária em qualquer suíte.",
                Destaque = "50% para crianças"
            },
            new Promocao
            {
                Emoji = "🌙",
                Titulo = "Fim de Semana Relax",
                Descricao = "Reservando sexta e sábado, você ganha o café da manhã.",
                Destaque = "Café incluso"
            },
            new Promocao
            {
                Emoji = "📅",
                Titulo = "Reserva Antecipada",
                Descricao = "Reserve com 30 dias de antecedência e ganhe desconto.",
                Destaque = "10% de desconto"
            },
            new Promocao
            {
                Emoji = "💑",
                Titulo = "Escapada a Dois",
                Descricao = "Suíte Luxo com decoração especial para casais.",
                Destaque = "Brinde de boas-vindas"
            }
        };
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}

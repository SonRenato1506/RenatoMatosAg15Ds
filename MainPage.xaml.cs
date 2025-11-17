using MauiAppEventos.Models;
using WebKit;

namespace MauiAppEventos;

public partial class MainPage : ContentPage
{
    public Evento EventoModel { get; set; }

    public MainPage()
    {
        InitializeComponent();

        EventoModel = new Evento()
        {
            DataInicio = DateTime.Today,
            DataTermino = DateTime.Today
        };

        BindingContext = EventoModel;
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ResumoPage(EventoModel));
    }
}

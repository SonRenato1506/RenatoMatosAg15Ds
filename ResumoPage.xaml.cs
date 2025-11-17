using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MauiAppEventos.Models;

namespace MauiAppEventos;

public partial class ResumoPage : ContentPage
{
    public ResumoPage(Evento evento)
    {
        InitializeComponent();

        lblNome.Text = $"Evento: {evento.Nome}";
        lblDatas.Text = $"Data: {evento.DataInicio:dd/MM/yyyy} até {evento.DataTermino:dd/MM/yyyy}";
        lblDuracao.Text = $"Duração: {evento.DuracaoDias} dias";
        lblParticipantes.Text = $"Participantes: {evento.NumeroParticipantes}";
        lblLocal.Text = $"Local: {evento.Local}";
        lblCusto.Text = $"Custo total: R$ {evento.CustoTotal:N2}";
    }
}


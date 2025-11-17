namespace MauiAppEventos
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            Routing.RegisterRoute(nameof(ResumoPage), typeof(ResumoPage));

            InitializeComponent();
        }
    }
}

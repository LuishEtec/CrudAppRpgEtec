namespace AppRpgEtec
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AppRpgEtec.Views.Usuarios.ImagemUsuarioView());
        }

    }
}
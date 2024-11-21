namespace ShareStreamApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Configura la primera página como MainPage
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
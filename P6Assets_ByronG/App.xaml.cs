using P6Assets_ByronG.Views;

namespace P6Assets_ByronG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}

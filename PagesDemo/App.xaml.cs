
namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new FlyoutPageDemo();
            MainPage = new TabbedPageDemo();
        }
    }
}

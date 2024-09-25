namespace PagesDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageDemo());
        }

        private void OnCounterClicked2(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }

}

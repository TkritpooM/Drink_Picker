namespace ProjectApp_101
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGetStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionPage1());
        }
    }

}

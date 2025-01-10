namespace ProjectApp_101;

public partial class QuestionPage1 : ContentPage
{
	public QuestionPage1()
	{
		InitializeComponent();
	}

    //Choice 1 Calm
    private async void OnChoiceTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuestionPage2());
    }

}
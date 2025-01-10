namespace ProjectApp_101;

public partial class QuestionPage2 : ContentPage
{
	public QuestionPage2()
	{
		InitializeComponent();
	}

    //Choice 1 Help me relax
    private async void OnChoice1Tapped(object sender, EventArgs e)
    {
        DataCollect.Tea += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage3());
    }

    //Choice 2 Boost my energy
    private async void OnChoice2Tapped(object sender, EventArgs e)
    {
        DataCollect.Coffee += 1;
        DataCollect.Juice += 1;
        await Navigation.PushAsync(new QuestionPage3());
    }
}
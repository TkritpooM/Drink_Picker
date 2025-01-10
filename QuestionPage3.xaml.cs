namespace ProjectApp_101;

public partial class QuestionPage3 : ContentPage
{
	public QuestionPage3()
	{
		InitializeComponent();
	}

    //Choice 1 Morning
    private async void OnChoice1Tapped(object sender, EventArgs e)
    {
        DataCollect.Coffee += 1;
        DataCollect.Juice += 1;
        await Navigation.PushAsync(new QuestionPage4());
    }

    //Choice 2 Afternoon
    private async void OnChoice2Tapped(object sender, EventArgs e)
    {
        DataCollect.Tea += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage4());
    }

    //Choice 3 Evening
    private async void OnChoice3Tapped(object sender, EventArgs e)
    {
        DataCollect.Tea += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage4());
    }

    //Choice 4 Night
    private async void OnChoice4Tapped(object sender, EventArgs e)
    {
        DataCollect.Tea += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage4());
    }
}
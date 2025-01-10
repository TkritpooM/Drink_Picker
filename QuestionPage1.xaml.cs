namespace ProjectApp_101;

public partial class QuestionPage1 : ContentPage
{
	public QuestionPage1()
	{
		InitializeComponent();
	}

    //Choice 1 Calm
    private async void OnChoice1Tapped(object sender, EventArgs e)
    {
        DataCollect.Tea += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage2());
    }

    //Choice 2 Excited
    private async void OnChoice2Tapped(object sender, EventArgs e)
    {
        DataCollect.Coffee += 1;
        DataCollect.Juice += 1;
        await Navigation.PushAsync(new QuestionPage2());
    }

    //Choice 3 Tired
    private async void OnChoice3Tapped(object sender, EventArgs e)
    {
        DataCollect.Coffee += 1;
        DataCollect.Tea += 1; 
        await Navigation.PushAsync(new QuestionPage2());
    }

    //Choice 4 Stressed
    private async void OnChoice4Tapped(object sender, EventArgs e)
    {
        DataCollect.Tea += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage2());
    }
}
namespace ProjectApp_101;

public partial class QuestionPage4 : ContentPage
{
	public QuestionPage4()
	{
		InitializeComponent();
	}

    //Choice 1 Hot
    private async void OnChoice1Tapped(object sender, EventArgs e)
    {
        DataCollect.Juice += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage5());
    }

    //Choice 2 Cold
    private async void OnChoice2Tapped(object sender, EventArgs e)
    {
        DataCollect.Coffee += 1;
        DataCollect.Tea += 1;
        await Navigation.PushAsync(new QuestionPage5());
    }

    //Choice 3 Rainy
    private async void OnChoice3Tapped(object sender, EventArgs e)
    {
        DataCollect.Coffee += 1;
        DataCollect.Tea += 1;
        await Navigation.PushAsync(new QuestionPage5());
    }

    //Choice 4 Cloudy
    private async void OnChoice4Tapped(object sender, EventArgs e)
    {
        DataCollect.Tea += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new QuestionPage5());
    }
}
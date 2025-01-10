namespace ProjectApp_101;

public partial class QuestionPage5 : ContentPage
{
	public QuestionPage5()
	{
		InitializeComponent();
	}

    //Choice 1 Hot drink
    private async void OnChoice1Tapped(object sender, EventArgs e)
    {
        DataCollect.Coffee += 1;
        DataCollect.Tea += 1;
        await Navigation.PushAsync(new DrinkCategory());
    }

    //Choice 2 Cold drink
    private async void OnChoice2Tapped(object sender, EventArgs e)
    {
        DataCollect.Juice += 1;
        DataCollect.Smoothee += 1;
        await Navigation.PushAsync(new DrinkCategory());
    }
}
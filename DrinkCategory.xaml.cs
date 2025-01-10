namespace ProjectApp_101;

public partial class DrinkCategory : ContentPage
{
	public DrinkCategory()
	{
		InitializeComponent();
        ShowResult();
    }

    public string choice1 = "";
    public string choice2 = "";
    public string choice3 = "";

    private void ShowResult()
    {
        string recommendedDrink = "";

        int maxScore = Math.Max(DataCollect.Coffee,
                        Math.Max(DataCollect.Tea,
                        Math.Max(DataCollect.Juice, DataCollect.Smoothee)));

        if (maxScore == DataCollect.Coffee)
        {
            recommendedDrink = "Coffee";
            choice1 = "Espresso";
            choice2 = "Latte";
            choice3 = "Cappuccino";
        }
        else if (maxScore == DataCollect.Tea)
        {
            recommendedDrink = "Tea";
            choice1 = "Green Tea";
            choice2 = "Black Tea";
            choice3 = "Matcha Latte";
        }
            
        else if (maxScore == DataCollect.Juice)
        {
            recommendedDrink = "Juice";
            choice1 = "Orange Juice";
            choice2 = "Apple Juice";
            choice3 = "Grape Juice";
        }
            
        else if (maxScore == DataCollect.Smoothee)
        {
            recommendedDrink = "Smoothie";
            choice1 = "Berry Smoothie";
            choice2 = "Banana Smoothie";
            choice3 = "Mango Smoothie";
        }

        ResultLabel.Text = $"What would you like to drink in {recommendedDrink} category?";
        Choice1.Text = $"{choice1}";
        Choice2.Text = $"{choice2}";
        Choice3.Text = $"{choice3}";
    }

    //Choice 1
    private async void OnChoice1Tapped(object sender, EventArgs e)
    {
        DataCollect.ChoosenDrink = choice1;
        await Navigation.PushAsync(new DataOfDrinks());
    }

    //Choice 2
    private async void OnChoice2Tapped(object sender, EventArgs e)
    {
        DataCollect.ChoosenDrink = choice2;
        await Navigation.PushAsync(new DataOfDrinks());
    }

    //Choice 3
    private async void OnChoice3Tapped(object sender, EventArgs e)
    {
        DataCollect.ChoosenDrink = choice3;
        await Navigation.PushAsync(new DataOfDrinks());
    }
}
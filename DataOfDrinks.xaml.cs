using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ProjectApp_101;

public partial class DataOfDrinks : ContentPage
{
    public DataOfDrinks()
    {
        InitializeComponent();
        ShowData();
    }

    private void ShowData()
    {
        string DrinkChoosen = DataCollect.ChoosenDrink;
        string filePath = "ProjectApp_101.Resources.drinks.txt"; // �������� Resources

        try
        {
            // ���� Reflection ���ʹ֧�����Ũҡ Embedded Resource
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(filePath))
            {
                if (stream != null)
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string[] drinkData = reader.ReadToEnd().Split('\n');

                        foreach (var line in drinkData)
                        {
                            var parts = line.Split('|'); // �¡�����Ŵ��� "|"

                            if (parts[0].Trim().Equals(DrinkChoosen.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                ChoosenDrink.Text = $"{parts[0]}";
                                Ingredient.Text = $"��ǹ��Сͺ: \n\t\t\t{parts[1]}";
                                Tastee.Text = $"�ʪҵ�: \n\t\t\t{parts[2]}";
                                Benefitss.Text = $"����ª��: \n\t\t\t{parts[3]}";
                                Suitablee.Text = $"���������Ѻ: \n\t\t\t{parts[4]}";

                                // ��Ŵ�ٻ�Ҿ���ç�Ѻ����ͧ����
                                string imageName = $"{DrinkChoosen.Trim().ToLower().Replace(" ","")}.png";  // ���صԪ�������ٻ���� "����ͧ����.png"
                                string resourceName = $"ProjectApp_101.Resources.Images.{imageName}";
                                DrinkImage.Source = ImageSource.FromFile($"Resources/Images/{imageName}");

                                return;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("��辺���� Resources");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"�Դ��ͼԴ��Ҵ: {ex.Message}");
        }
    }

    private void OnStartAgainClicked(object sender, EventArgs e)
    {
        DataCollect.ResetData();
        Navigation.PopToRootAsync(); // Return to mainpage
    }
}
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
        string filePath = "ProjectApp_101.Resources.drinks.txt"; // ชื่อไฟล์ใน Resources

        try
        {
            // ใช้การ Reflection เพื่อดึงข้อมูลจาก Embedded Resource
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
                            var parts = line.Split('|'); // แยกข้อมูลด้วย "|"

                            if (parts[0].Trim().Equals(DrinkChoosen.Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                ChoosenDrink.Text = $"{parts[0]}";
                                Ingredient.Text = $"ส่วนประกอบ: \n\t\t\t{parts[1]}";
                                Tastee.Text = $"รสชาติ: \n\t\t\t{parts[2]}";
                                Benefitss.Text = $"ประโยชน์: \n\t\t\t{parts[3]}";
                                Suitablee.Text = $"เหมาะสำหรับ: \n\t\t\t{parts[4]}";

                                // โหลดรูปภาพที่ตรงกับเครื่องดื่ม
                                string imageName = $"{DrinkChoosen.Trim().ToLower().Replace(" ","")}.png";  // สมมุติชื่อไฟล์รูปจะเป็น "เครื่องดื่ม.png"
                                string resourceName = $"ProjectApp_101.Resources.Images.{imageName}";
                                DrinkImage.Source = ImageSource.FromFile($"Resources/Images/{imageName}");

                                return;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ไม่พบไฟล์ใน Resources");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"เกิดข้อผิดพลาด: {ex.Message}");
        }
    }

    private void OnStartAgainClicked(object sender, EventArgs e)
    {
        DataCollect.ResetData();
        Navigation.PopToRootAsync(); // Return to mainpage
    }
}
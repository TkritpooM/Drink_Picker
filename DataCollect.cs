namespace ProjectApp_101;

public static class DataCollect
{
    public static int Coffee { get; set; } = 0; // ตัวแปรเก็บคะแนน
    public static int Tea { get; set; } = 0; // ตัวแปรเก็บคะแนน
    public static int Juice { get; set; } = 0; // ตัวแปรเก็บคะแนน
    public static int Smoothee { get; set; } = 0; // ตัวแปรเก็บคะแนน
    public static string ChoosenDrink { get; set; } = ""; // เก็บเครื่องดื่มที่เลือกเพื่อแสดงผล
    public static void ResetData()
    {
        Coffee = 0;
        Tea = 0;
        Juice = 0;
        Smoothee = 0;
        ChoosenDrink = "";
    }
}
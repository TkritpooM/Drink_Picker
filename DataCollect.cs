namespace ProjectApp_101;

public static class DataCollect
{
    public static int Coffee { get; set; } = 0; // ������纤�ṹ
    public static int Tea { get; set; } = 0; // ������纤�ṹ
    public static int Juice { get; set; } = 0; // ������纤�ṹ
    public static int Smoothee { get; set; } = 0; // ������纤�ṹ
    public static string ChoosenDrink { get; set; } = ""; // ������ͧ����������͡�����ʴ���
    public static void ResetData()
    {
        Coffee = 0;
        Tea = 0;
        Juice = 0;
        Smoothee = 0;
        ChoosenDrink = "";
    }
}
using StockManagement.View;
using StockManagementLibrary;

class main
{
    public static void Main(string[] args)
    {
        BahasaConfig bahasaConfig = new BahasaConfig();
        Console.WriteLine(Path.GetFullPath(BahasaConfig.filePath));

        StartupView startupView = new StartupView();

        startupView.callMenu();
    }
}
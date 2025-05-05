using StockManagement.View;
using StockManagementLibrary;

class main
{
    public static void Main(string[] args)
    {
        StartupView startupView = new StartupView();
        startupView.selectLanguage();
        startupView.callMenu();
    }
}
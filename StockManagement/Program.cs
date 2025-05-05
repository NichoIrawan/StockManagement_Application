using StockManagement.Controllers;
using StockManagement.View;
using StockManagementLibrary;

class main
{
    public static async Task Main()
    {
        StartupView startupView = new StartupView();
        startupView.selectLanguage();
        startupView.callMenu();
    }
}
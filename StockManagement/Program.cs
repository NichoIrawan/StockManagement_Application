// See https://aka.ms/new-console-template for more information
using StockManagement.Controllers.UserController;
using StockManagement.View;
class TestRun() {
    static void Main() {
        StartupView view = new StartupView();
        view.callMenu();
    }
}
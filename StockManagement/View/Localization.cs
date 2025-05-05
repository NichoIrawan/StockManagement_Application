using System.Globalization;
using System.Threading;
using StockManagement.View.Resources; // If resource files are here

public static class Localization
{
    public static void SetLanguage(string langCode)
    {
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(langCode);
    }

    public static string Get(string key)
    {
        return Resources.ResourceManager.GetString(key);
    }
}

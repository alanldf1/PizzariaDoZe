using System.Configuration;
using System.Globalization;

namespace PizzariaDoZe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String? mainLanguage = (ConfigurationManager.AppSettings.Get("mainLanguage") is not null) ? ConfigurationManager.AppSettings.Get("mainLanguage") : ""; 
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(mainLanguage!);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(mainLanguage!);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu());
        }
    }
}
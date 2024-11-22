using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace SV_Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CrearHostBuilder().Build();

            Application.Run(new Form1());
        }

        static IHostBuilder CrearHostBuilder() =>
            Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => 
                { config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); }
            );

    }
}
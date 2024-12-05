using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SV_Presentacion.FORMULARIOS;
using SV_Repositorio;
using SV_Servicios;

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
            var formService = host.Services.GetRequiredService<frmCategoria>();

            Application.Run(formService);
        }

        static IHostBuilder CrearHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => 
                { config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); })
            .ConfigureServices((context, services) =>
                {
                    services.registroDatos();
                    services.registrarServicios();


                    //llamar al formulario como un servicio
                    services.AddTransient<frmCategoria>();

                    // Registrar formularios
                    services.AddTransient<frmCategoria>();
                    services.AddTransient<frmVenta>();
                    services.AddTransient<frmProducto>();
                });

    }
}
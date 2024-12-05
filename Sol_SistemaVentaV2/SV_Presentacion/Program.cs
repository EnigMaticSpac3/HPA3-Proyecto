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
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CrearHostBuilder().Build();
            var menuPrincipal = host.Services.GetRequiredService<frmMenuPrincipal>();

            Application.Run(menuPrincipal);
        }

        static IHostBuilder CrearHostBuilder() => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.registroDatos();
                services.registrarServicios();

                // Registrar formularios
                services.AddTransient<frmMenuPrincipal>();
                services.AddTransient<frmCategoria>();
                services.AddTransient<frmProducto>();
                services.AddTransient<frmVenta>();
            });
    }
}

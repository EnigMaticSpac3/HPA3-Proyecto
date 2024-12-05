using Microsoft.Extensions.DependencyInjection;
using SV_Repositorio.BD;
using SV_Servicios.IMPLEMENTACION;
using SV_Servicios.INTERFACES;

namespace SV_Servicios
{
    public static class serviciosInjections
    {
        public static void registrarServicios(this IServiceCollection services)
        {
            services.AddTransient<Conexion>(); // se registra la conexion
            services.AddTransient<IMedidaServicios, MedidaServicios>();
            services.AddTransient<ICategoriaServicios, CategoriaServicios>();
            services.AddTransient<IProductoServicios, ProductoServicios>();
            services.AddTransient<ICorrelativoVentaServicios, CorrelativoVentaServicios>();
            services.AddTransient<IVentaServicios, VentaServicios>();
        }




    }
}

using Microsoft.Extensions.DependencyInjection;
using SV_Servicios.IMPLEMENTACION;
using SV_Servicios.INTERFACES;

namespace SV_Servicios
{
    public static class serviciosInjections
    {
        public static void registrarServicios(this IServiceCollection services)
        {
            services.AddTransient<IMedidaServicios, MedidaServicios>();
            services.AddTransient<ICategoriaServicios, CategoriaServicios>();
            //services.AddTransient<IProductoRepositorio, ProductoRepositorio>();
        }




    }
}

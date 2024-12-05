using Microsoft.Extensions.DependencyInjection;
using SV_Repositorio.BD;
using SV_Repositorio.IMPLEMENTACION;
using SV_Repositorio.INTERFACES;

namespace SV_Repositorio
{
    public static class DatosInjections
    {
        public static void registroDatos(this IServiceCollection services) 
        {
            services.AddTransient<Conexion>(); // se registra la conexion
            services.AddTransient<IMedidaRepositorio, MedidaRepositorio>();
            services.AddTransient<ICategoriaRepositorio, CategoriaRepositorio>();
            services.AddTransient<IProductoRepositorio, ProductoRepositorio>();
            services.AddTransient<ICorrelativoVentaRepositorio, CorrelativoVentaRepositorio>();
            services.AddTransient<IVentaRepositorio, VentaRepositorio>();

        }


        

    }
}

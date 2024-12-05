using SV_Repositorio.Entidades;

namespace SV_Servicios.INTERFACES
{
    public interface ICorrelativoVentaServicios
    {
        Task<CorrelativoVenta> ObtenerCorrelativoVenta();
        Task<string> ActualizarCorrelativo(CorrelativoVenta correlativoVenta);
    }
}

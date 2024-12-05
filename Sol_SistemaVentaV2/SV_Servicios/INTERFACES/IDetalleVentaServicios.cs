using SV_Repositorio.Entidades;

namespace SV_Servicios.INTERFACES
{
    public interface IDetalleVentaServicios
    {
        Task<List<DetalleVenta>> listaDetalleVenta(int idVenta);
        Task<string> CrearDetalleVenta(DetalleVenta detalleVenta);
    }
}

using SV_Repositorio.Entidades;

namespace SV_Repositorio.INTERFACES
{
    public interface IDetalleVentaRepositorio
    {
        Task<List<DetalleVenta>> listaDetalleVenta(int idVenta);
        Task<string> CrearDetalleVenta(DetalleVenta detalleVenta);
    }
}

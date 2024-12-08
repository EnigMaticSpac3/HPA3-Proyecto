using SV_Repositorio.Entidades;

namespace SV_Servicios.INTERFACES
{
    public interface IVentaServicios
    {
        Task<List<Venta>> listaVenta(string buscar = "");
        Task<string> CrearVenta(Venta venta);
        Task<List<DetalleVenta>> ObtenerDetalleVenta(string numeroVenta);

    }
}

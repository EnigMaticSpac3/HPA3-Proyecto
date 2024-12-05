using SV_Repositorio.Entidades;

namespace SV_Repositorio.INTERFACES
{
    public interface IVentaRepositorio
    {
        Task<List<Venta>> listaVenta(string buscar = "");
        Task<string> CrearVenta(Venta venta);
    }
}

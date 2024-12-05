using SV_Repositorio.ENTIDADES;

namespace SV_Servicios.INTERFACES
{
    public interface ICompraServicios
    {
        Task<List<Compra>> ListarCompras(string buscar = "");
        Task<string> CrearCompra(Compra compra);
        Task<string> EditarCompra(Compra compra);
    }
}

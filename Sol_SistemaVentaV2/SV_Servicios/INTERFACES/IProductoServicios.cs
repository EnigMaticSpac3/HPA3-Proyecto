using SV_Repositorio.ENTIDADES;

namespace SV_Servicios.INTERFACES
{
    public interface IProductoServicios
    {
        Task<List<Producto>> listaProducto(string buscar = "");
        Task<string> CrearProducto(Producto producto);
        Task<string> EditarProducto(Producto producto);
    }
}

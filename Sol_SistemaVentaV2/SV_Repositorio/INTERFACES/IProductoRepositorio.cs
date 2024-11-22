using SVRepositorio.ENTIDADES;

namespace SVRepositorio.INTERFACE
{
    public interface IProductoRepositorio
    {
        Task<List<Producto>> listaProducto(string buscar = "");
        Task<string> CrearProducto(Producto producto);
        Task<string> EditarProducto(Producto producto);
    }
}

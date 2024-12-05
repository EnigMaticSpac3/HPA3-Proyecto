using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class ProductoServicios : IProductoServicios
    {
        private readonly IProductoRepositorio _productoRepositorio;
        public ProductoServicios(IProductoRepositorio productoRepositorio)
        {
            _productoRepositorio = productoRepositorio;
        }
        public async Task<string> CrearProducto(Producto producto)
        {
            return await _productoRepositorio.CrearProducto(producto);
        }

        public async Task<string> EditarProducto(Producto producto)
        {
            return await _productoRepositorio.EditarProducto(producto);
        }

        public async Task<List<Producto>> listaProducto(string buscar = "")
        {
            return await _productoRepositorio.listaProducto(buscar);
        }
    }
}

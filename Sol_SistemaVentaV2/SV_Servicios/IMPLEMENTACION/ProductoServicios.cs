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
            try
            {
                // Llamada al repositorio para actualizar el producto en la base de datos
                return await _productoRepositorio.EditarProducto(producto);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return $"Error al actualizar el producto: {ex.Message}";
            }
        }

        public async Task<List<Producto>> listaProducto(string buscar = "")
        {
            return await _productoRepositorio.listaProducto(buscar);
        }
    }
}

using SV_Repositorio.Entidades;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class VentaServicios : IVentaServicios
    {
        private readonly IVentaRepositorio _ventaRepositorio;
        public VentaServicios(IVentaRepositorio ventaRepositorio)
        {
            _ventaRepositorio = ventaRepositorio;
        }
        public async Task<string> CrearVenta(Venta venta)
        {
            return await _ventaRepositorio.CrearVenta(venta);
        }

        public async Task<List<Venta>> listaVenta(string buscar = "")
        {
            return await _ventaRepositorio.listaVenta(buscar);
        }
    }
}

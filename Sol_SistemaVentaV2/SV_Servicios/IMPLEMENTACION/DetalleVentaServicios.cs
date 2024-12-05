using SV_Repositorio.Entidades;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class DetalleVentaServicios : IDetalleVentaServicios
    {
        private readonly IDetalleVentaRepositorio _detalleVentaRepositorio;
        public DetalleVentaServicios(IDetalleVentaRepositorio detalleVentaRepositorio)
        {
            _detalleVentaRepositorio = detalleVentaRepositorio;
        }
        public async Task<string> CrearDetalleVenta(DetalleVenta detalleVenta)
        {
            return await _detalleVentaRepositorio.CrearDetalleVenta(detalleVenta);
        }

        public async Task<List<DetalleVenta>> listaDetalleVenta(int idVenta)
        {
            return await _detalleVentaRepositorio.listaDetalleVenta(idVenta);
        }
    }
}

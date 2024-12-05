using SV_Repositorio.Entidades;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class CorrelativoVentaServicios : ICorrelativoVentaServicios
    {
        private readonly ICorrelativoVentaRepositorio _correlativoVentaRepositorio;
        public CorrelativoVentaServicios(ICorrelativoVentaRepositorio correlativoVentaRepositorio)
        {
            _correlativoVentaRepositorio = correlativoVentaRepositorio;
        }
        public async Task<string> ActualizarCorrelativo(CorrelativoVenta correlativoVenta)
        {
            return await _correlativoVentaRepositorio.ActualizarCorrelativo(correlativoVenta);
        }

        public async Task<CorrelativoVenta> ObtenerCorrelativoVenta()
        {
            return await _correlativoVentaRepositorio.ObtenerCorrelativoVenta();
        }
    }
}

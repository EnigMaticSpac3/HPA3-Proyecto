using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class CompraServicios : ICompraServicios
    {
        private readonly ICompraRepositorio _compraRepositorio;

        public CompraServicios(ICompraRepositorio compraRepositorio)
        {
            _compraRepositorio = compraRepositorio;
        }

        public async Task<List<Compra>> ListarCompras(string buscar = "")
        {
            return await _compraRepositorio.ListarCompras(buscar);
        }

        public async Task<string> CrearCompra(Compra compra)
        {
            return await _compraRepositorio.CrearCompra(compra);
        }

        public async Task<string> EditarCompra(Compra compra)
        {
            return await _compraRepositorio.EditarCompra(compra);
        }
    }
}

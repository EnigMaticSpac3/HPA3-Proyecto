using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;

namespace SV_Servicios.IMPLEMENTACION
{
    public class MedidaServicios : IMedidaServicios
    {
        private readonly IMedidaRepositorio _medidaRepositorio;
        public MedidaServicios(IMedidaRepositorio medidaRepositorio)
        {
            _medidaRepositorio = medidaRepositorio;
        }

        public async Task<List<Medida>> listaMedida()
        {
            return await _medidaRepositorio.listaMedida();
        }
    }
}

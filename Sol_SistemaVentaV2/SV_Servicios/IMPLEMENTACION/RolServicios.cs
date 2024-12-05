using SV_Repositorio.Entidades;
using SV_Repositorio.ENTIDADES;
using SV_Repositorio.INTERFACES;
using SV_Servicios.INTERFACES;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SV_Servicios.IMPLEMENTACION
{
    public class RolServicios : IRolServicios
    {
        private readonly IRolRepositorio _rolRepositorio;

        public RolServicios(IRolRepositorio rolRepositorio)
        {
            _rolRepositorio = rolRepositorio;
        }

        public async Task<List<Rol>> ListarRoles(string buscar = "")
        {
            return await _rolRepositorio.ListarRoles(buscar);
        }

        public async Task<string> CrearRol(Rol objeto)
        {
            return await _rolRepositorio.CrearRol(objeto);
        }

        public async Task<string> EditarRol(Rol objeto)
        {
            return await _rolRepositorio.EditarRol(objeto);
        }
    }
}
